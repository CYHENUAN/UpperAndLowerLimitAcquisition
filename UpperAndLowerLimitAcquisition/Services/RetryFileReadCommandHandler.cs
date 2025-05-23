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
    public class RetryFileReadCommandHandler: IRequest<RetryAllFileReadCommand>, IRequest<RetrySingeFileReadCommand>
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
                var success = await _pressService.TryReadFileAsync(request.FailedFileToRetry);
                if (success)
                {
                    await _mediator.Publish(new AcquisitionProgressSuccessNotification("", 0, 0, 0)); // 可携带具体计数
                }
                else
                {
                    await _mediator.Publish(new AcquisitionProgressFailedNotification("", 0, 0, 0, new List<DirectoryInfo> {request.FailedFileToRetry }));
                }
            }
            catch
            {
                await _mediator.Publish(new AcquisitionProgressFailedNotification("", 0, 0, 0, new List<DirectoryInfo> {request.FailedFileToRetry }));
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
                    var success = await _pressService.TryReadFileAsync(file);
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
