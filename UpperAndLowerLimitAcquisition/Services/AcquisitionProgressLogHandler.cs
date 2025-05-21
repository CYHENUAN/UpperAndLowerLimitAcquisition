using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using UpperAndLowerLimitAcquisition.Model;

namespace UpperAndLowerLimitAcquisition.Services
{
    public class AcquisitionProgressLogHandler : INotificationHandler<AcquisitionLogNotification>
    {
        public readonly LogService _logService;

        public AcquisitionProgressLogHandler(LogService logService)
        {
            _logService = logService;
        }

        public Task Handle(AcquisitionLogNotification notification, CancellationToken cancellationToken)
        {           
            string category = notification.EquipmentTypeInfo.ToString();
            int index = Convert.ToInt32(notification.EquipmentTypeInfo);
            string message = notification.Message ?? string.Empty; 
            _logService.AddMsg(category, index, message); 
            return Task.CompletedTask;
        }
    }
}
