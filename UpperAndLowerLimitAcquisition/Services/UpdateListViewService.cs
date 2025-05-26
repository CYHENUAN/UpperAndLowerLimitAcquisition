using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpperAndLowerLimitAcquisition.ISevices;
using UpperAndLowerLimitAcquisition.Model;

namespace UpperAndLowerLimitAcquisition.Services
{
    public class UpdateListViewService : IUpdateListViewService
    {
        public BindingList<PressDetailDto> pressDetails { get; set; } = new BindingList<PressDetailDto>();
        public readonly DataGridView dataGridView;

        public UpdateListViewService(DataGridView dataGrid)
        {
            dataGridView = dataGrid;
        }
        public void SetListViewList(BindingList<PressDetailDto> pressDetailDtos)
        {
            pressDetails = pressDetailDtos;
        }

        public void UpdateListView()
        {
            // 如果在UI线程外调用，则使用Invoke方法来更新UI
            if (dataGridView.InvokeRequired)
            {
                dataGridView.Invoke(() => UpdateListView());
            }
            dataGridView.DataSource = pressDetails;
            
        }

        public PressDetailDto CreatePressDetailDto(string station, string equipment, string source, AcquistionState state)
        {
            Image icon;
            using (var ms = new MemoryStream(state == AcquistionState.Sucess ? Properties.Resources.Sucess : Properties.Resources.Error))
            {
                icon = Image.FromStream(ms);
            }
            return new PressDetailDto
            {
                StationName = station,
                EquimentName = equipment,
                FailFileSource = source,
                State = state,
                Icon = icon
            };
        }
    }
}
