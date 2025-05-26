using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperAndLowerLimitAcquisition.ISevices
{
    public interface IPanelRegistry
    {      
        void RegisterPanel(string panelId, ILabelPanelUpdater panel);
        void UnregisterPanel(string panelId);
        ILabelPanelUpdater? GetPanel(string panelId);
        IUpdateListViewService? GetListView(string panelId);
        void RegisterListView(string panelId, IUpdateListViewService dataGridView);
    }
}
