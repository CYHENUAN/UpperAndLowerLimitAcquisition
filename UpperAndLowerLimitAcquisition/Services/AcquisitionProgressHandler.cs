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
    public class AcquisitionProgressHandler: INotificationHandler<AcquisitionProgressSuccessNotification>,INotificationHandler<AcquisitionProgressFailedNotification>, INotificationHandler<DataListViewNotification>
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

        public Task Handle(DataListViewNotification notification, CancellationToken cancellationToken)
        {
            var listView = _registry.GetListView(notification.PanelId);
            if (notification.StationName == null || notification.EquimentName == null || notification.FailFileSource == null)
            {
                throw new ArgumentNullException("StationName, EquimentName, and FailFileSource cannot be null.");
            }

            var pressListData = listView?.CreatePressDetailDto(notification.StationName, notification.EquimentName, notification.FailFileSource, notification.State);

            if (pressListData == null)
            {
                throw new InvalidOperationException("CreatePressDetailDto returned null.");
            }
            listView?.SetListViewList(pressListData);
            listView?.UpdateListView();
            return Task.CompletedTask;
        }

    }
   
}
