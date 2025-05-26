using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Win32;
using UpperAndLowerLimitAcquisition.Equipment.Press;
using UpperAndLowerLimitAcquisition.ISevices;
using UpperAndLowerLimitAcquisition.Model;

namespace UpperAndLowerLimitAcquisition.Services
{
    public class RetryFileReadCommandHandler: IRequestHandler<RetryAllFileReadCommand, Unit>, IRequestHandler<RetrySingeFileReadCommand, Unit>
    {
        private readonly IMediator _mediator;
        private readonly PressService _pressService;
        private readonly IPanelRegistry _registry;
        public RetryFileReadCommandHandler(IMediator mediator, PressService pressService, IPanelRegistry panelRegistry) 
        {
            _mediator = mediator;
            _pressService = pressService;
            _registry = panelRegistry;
        }

        ///处理单个文件重试读取命令
        public async Task<Unit> Handle(RetrySingeFileReadCommand request, CancellationToken cancellationToken)
        {                 
            try
            {
                
                //读取逻辑暂定
                var success = await _pressService.TryReadFileAsync(request.FailedFileToRetry, cancellationToken);
                int total = request.TotalCount;
                int sucess = request.SuccessCount;
                int fail = request.FailedCount;
                if (success)
                {                              
                    //读取成功后，更新面板状态 ->  成功数 + 1， 失败数 - 1
                    sucess++;
                    fail--;
                    await _mediator.Publish(new AcquisitionProgressSuccessNotification(request.PanelId, total, sucess, fail));

                    //输出日志
                    await _mediator.Publish(
                                new AcquisitionLogNotification(EquipmentType.Press, LogLevel.Info, $"{request.FailedFileToRetry} -> 重试同步上下限成功; 当前同步成功数:{sucess}, 失败数：{fail}"),
                                cancellationToken);
                }
                else
                {
                    //输出日志
                    await _mediator.Publish(
                                new AcquisitionLogNotification(EquipmentType.Press, LogLevel.Error, $"{request.FailedFileToRetry} -> 重试同步上下限失败"),
                                cancellationToken);
                }
            }
            catch
            {
                //输出日志
                await _mediator.Publish(
                            new AcquisitionLogNotification(EquipmentType.Press, LogLevel.Error, $"{request.FailedFileToRetry} -> 重试同步上下限失败"),
                            cancellationToken);
            }
            return Unit.Value;
        }
        //处理所有文件重试读取命令
        public async Task<Unit> Handle(RetryAllFileReadCommand request, CancellationToken cancellationToken)
        {
            var panel = _registry.GetPanel(request.PanelId);
            if (panel == null)
            {               
                await _mediator.Publish(new AcquisitionProgressFailedNotification("", 0, 0, 0, new List<DirectoryInfo>()));
                return Unit.Value;
            }
            foreach (var file in panel.GetFailedFiles())
            {
                try
                {
                    //读取逻辑暂定
                    var success = await _pressService.TryReadFileAsync(file, cancellationToken);
                    if (success)
                    {
                        await _mediator.Publish(new AcquisitionProgressSuccessNotification("", 0, 0, 0)); // 可携带具体计数
                    }
                    else
                    {
                        await _mediator.Publish(new AcquisitionProgressFailedNotification("", 0, 0, 0, new List<DirectoryInfo> { file }));
                    }
                }
                catch
                {
                    await _mediator.Publish(new AcquisitionProgressFailedNotification("", 0, 0, 0, new List<DirectoryInfo> { file }));
                }
            }

            return Unit.Value;
        }

    }

    
}
