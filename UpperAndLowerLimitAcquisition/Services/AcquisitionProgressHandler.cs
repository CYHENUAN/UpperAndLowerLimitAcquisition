using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using UpperAndLowerLimitAcquisition.ISevices;
using UpperAndLowerLimitAcquisition.Model;

namespace UpperAndLowerLimitAcquisition.Services
{
    public class AcquisitionProgressHandler: INotificationHandler<AcquisitionProgressSuccessNotification>,INotificationHandler<AcquisitionProgressFailedNotification>
    {
        private readonly IPanelRegistry _registry;      
        public AcquisitionProgressHandler(IPanelRegistry registry)
        {
            _registry = registry;
        }
        public Task Handle(AcquisitionProgressSuccessNotification notification, CancellationToken cancellationToken)
        {
            var panel = _registry.GetPanel(notification.PanelId);
            panel?.UpdateLabels(notification.TotalCount, notification.SuccessCount, notification.FailedCount);
            return Task.CompletedTask;
        }

        public Task Handle(AcquisitionProgressFailedNotification notification, CancellationToken cancellationToken)
        {
            var panel = _registry.GetPanel(notification.PanelId);
            panel?.UpdateLabels(notification.TotalCount, notification.SuccessCount, notification.FailedCount);
            panel?.SetFailedFiles(notification.FailedFiles);
            return Task.CompletedTask;
        }
    }
   
}
