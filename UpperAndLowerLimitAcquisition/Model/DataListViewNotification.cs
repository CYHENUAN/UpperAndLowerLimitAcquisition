using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace UpperAndLowerLimitAcquisition.Model
{
    public class DataListViewNotification: INotification
    {
        public string PanelId { get;}
        public string? StationName { get; }
        public string? EquimentName { get;}
        public string? FailFileSource { get; }
        public Image? Icon { get; }
        public AcquistionState State { get;}       
        public DataListViewNotification(string panelId, string stationName, string equimentMent, string failFileSource, AcquistionState state)
        {
            PanelId = panelId;
            StationName = stationName;
            EquimentName = equimentMent;
            FailFileSource = failFileSource;
            State = state;
        }
    }
}
