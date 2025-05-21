using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using UpperAndLowerLimitAcquisition.Model;

namespace UpperAndLowerLimitAcquisition.Services
{
    public class RetryFileReadCommandHandler: IRequest<RetryFileReadCommand>
    {
        private readonly IMediator _mediator;
        public RetryFileReadCommandHandler(IMediator mediator) 
        {
            _mediator = mediator;
        }
        public async Task<Unit> Handle(RetryFileReadCommand request, CancellationToken cancellationToken)
        {
            foreach (var file in request.FailedFilesToRetry)
            {
                try
                {
                    //读取逻辑暂定
                    var success = await TryReadFileAsync(file);
                    if (success)
                    {
                        await _mediator.Publish(new AcquisitionProgressSuccessNotification("",0, 0, 0)); // 可携带具体计数
                    }
                    else
                    {
                        await _mediator.Publish(new AcquisitionProgressFailedNotification("",0, 0, 0,new List<string> { file }));
                    }
                }
                catch
                {
                    await _mediator.Publish(new AcquisitionProgressFailedNotification("", 0, 0, 0, new List<string> { file }));
                }
            }

            return Unit.Value;
        }



        private Task<bool> TryReadFileAsync(string file)
        {
            // 你自己的读取逻辑
            return Task.FromResult(true);
        }
    }

    
}
