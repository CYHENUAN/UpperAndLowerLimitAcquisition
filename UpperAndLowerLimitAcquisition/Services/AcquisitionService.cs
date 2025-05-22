using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using UpperAndLowerLimitAcquisition.Equipment.Press;
using UpperAndLowerLimitAcquisition.Model;

namespace UpperAndLowerLimitAcquisition.Services
{
    public class AcquisitionService
    {
        private readonly IMediator _mediator;
        private readonly PressService _pressService;
        private readonly int _maxRetry = 3;
        private readonly int _retryDelayMs = 500;

        public AcquisitionService(IMediator mediator, PressService pressService)
        {
            _mediator = mediator;
            _pressService = pressService;
        }


        //压机读取文件服务
        public async Task ReadAllFilesAsync(string folderPath, CancellationToken cancellationToken)
        {
            int total = 0, success = 0, failed = 0;

            foreach(var file in new DirectoryInfo(folderPath).GetDirectories())
            {
                //读取文件逻辑处理
                if (cancellationToken.IsCancellationRequested)
                    break;

                total++;         
                
                //读取失败重试
                for (int attempt = 1; attempt <= _maxRetry; attempt++)
                {
                    try
                    {
                        var IsReadSuccess = await _pressService.TryReadFileAsync(file);
                        if (IsReadSuccess)
                        {
                            success++;

                            //通知更新UI
                            await _mediator.Publish(
                                new AcquisitionProgressSuccessNotification("press", total, success, failed),
                                cancellationToken);
                            break;
                        }
                        else
                        {
                            if (attempt == _maxRetry)
                            {
                                failed++;
                                //通知更新UI
                                await _mediator.Publish(
                                    new AcquisitionProgressFailedNotification("press", total, success, failed, new List<DirectoryInfo>() { file }),
                                    cancellationToken);
                                
                                //记录日志
                                await _mediator.Publish(
                                    new AcquisitionLogNotification(EquipmentType.Press, LogLevel.Error, $"{file.Name}压机数据读取失败，正在进行第{attempt}次重新读取尝试"),
                                    cancellationToken);
                            }
                            else
                            {
                                await Task.Delay(_retryDelayMs, cancellationToken);
                            }
                        }                                          
                    }
                    catch (Exception ex)
                    {
                        if (attempt == _maxRetry)
                        {
                            failed++;
                            //通知更新UI
                            await _mediator.Publish(
                                new AcquisitionProgressFailedNotification("", total, success, failed, new List<DirectoryInfo>() { file}),
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
