using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using UpperAndLowerLimitAcquisition.Model;

namespace UpperAndLowerLimitAcquisition.Services
{
    public class AcquisitionService
    {
        private readonly IMediator _mediator;
        private readonly int _maxRetry = 3;
        private readonly int _retryDelayMs = 500;

        public AcquisitionService(IMediator mediator)
        {
            _mediator = mediator;
        }


        //压机读取文件服务
        public async Task ReadAllFilesAsync(string folderPath, CancellationToken cancellationToken)
        {
            int total = 0, success = 0, failed = 0;

            foreach(var file in Directory.GetFiles(folderPath))
            {
                //读取文件逻辑处理
                if (cancellationToken.IsCancellationRequested)
                    break;

                total++;         
                
                for (int attempt = 1; attempt <= _maxRetry; attempt++)
                {
                    try
                    {
                        var content = await File.ReadAllTextAsync(file, cancellationToken);
                        success++;

                        //通知更新UI
                        await _mediator.Publish(
                            new AcquisitionProgressSuccessNotification("",total,success,failed),
                            cancellationToken);                      
                        break;
                    }
                    catch (Exception ex)
                    {
                        if (attempt == _maxRetry)
                        {
                            failed++;
                            //通知更新UI
                            await _mediator.Publish(
                                new AcquisitionProgressFailedNotification("", total, success, failed, new List<string>() { file}),
                                cancellationToken);
                            //记录日志
                            await _mediator.Publish(
                                new AcquisitionLogNotification(EquipmentType.Press,LogLevel.Error,$"读取压机数据失败，Error:{ex.Message}"),
                                cancellationToken);
                        }
                        else
                        {
                            await Task.Delay(_retryDelayMs, cancellationToken);
                        }
                    }
                }                
            }           
        }
    }
}
