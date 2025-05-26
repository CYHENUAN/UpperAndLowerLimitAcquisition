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
        public string? PanelId { get; set; }
        public string? StationName { get; set; }
        public string? EquimentName { get; set; }
        public string? FailFileSource { get; set; }
        public Image? Icon { get; set; }
        public AcquistionState State { get; set; }
        public BindingList<PressDetailDto> PressDetailDtos = new BindingList<PressDetailDto>();
       
    }
}
