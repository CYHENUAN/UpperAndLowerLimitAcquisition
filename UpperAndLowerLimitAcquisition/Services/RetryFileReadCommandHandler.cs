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
    public class RetryFileReadCommandHandler: IRequest<RetryFileReadCommand>
    {
        private readonly IMediator _mediator;
        private readonly PressService _pressService;
        public RetryFileReadCommandHandler(IMediator mediator, PressService pressService) 
        {
            _mediator = mediator;
            _pressService = pressService;
        }
        public async Task<Unit> Handle(RetryFileReadCommand request, CancellationToken cancellationToken)
        {
            foreach (var file in request.FailedFilesToRetry)
            {
                try
                {
                    //读取逻辑暂定
                    var success = await _pressService.TryReadFileAsync(file);
                    if (success)
                    {
                        await _mediator.Publish(new AcquisitionProgressSuccessNotification("",0, 0, 0)); // 可携带具体计数
                    }
                    else
                    {
                        await _mediator.Publish(new AcquisitionProgressFailedNotification("",0, 0, 0, new List<DirectoryInfo> { file }));
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
