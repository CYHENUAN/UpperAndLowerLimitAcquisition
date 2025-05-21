using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpperAndLowerLimitAcquisition.ISevices;

namespace UpperAndLowerLimitAcquisition.Services
{
    public class PanelRegistry : IPanelRegistry
    {
        private readonly Dictionary<string, ILabelPanelUpdater> _panels = new();
        public ILabelPanelUpdater? GetPanel(string panelId)
        {
            _panels.TryGetValue(panelId, out var panel);
            return panel;
        }

        public void RegisterPanel(string panelId, ILabelPanelUpdater panel)
        {
            if (!_panels.ContainsKey(panelId))
                _panels[panelId] = panel;
        }

        public void UnregisterPanel(string panelId)
        {
            _panels.Remove(panelId);
        }
    }
}
