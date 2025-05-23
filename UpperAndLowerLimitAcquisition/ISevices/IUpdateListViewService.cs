using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpperAndLowerLimitAcquisition.Model;

namespace UpperAndLowerLimitAcquisition.ISevices
{
    public interface IUpdateListViewService
    {
        public BindingList<PressDetailDto> pressDetails { get; set; }
        void UpdateListView();
        void SetListViewList(PressDetailDto pressDetailDtos);
        PressDetailDto CreatePressDetailDto(string station, string equipment, string source, AcquistionState state);

    }
}
