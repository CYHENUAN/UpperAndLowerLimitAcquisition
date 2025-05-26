using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediatR;
using UpperAndLowerLimitAcquisition.ISevices;
using UpperAndLowerLimitAcquisition.Model;
using UpperAndLowerLimitAcquisition.Services;
using static System.Windows.Forms.AxHost;

namespace UpperAndLowerLimitAcquisition
{
    public partial class FormDetailList : Form
    {
        private readonly IPanelRegistry _panelRegistry;
        private readonly IMediator _mediator;
        public FormDetailList(IPanelRegistry panelRegistry, IMediator mediator)
        {
            InitializeComponent();
            _panelRegistry = panelRegistry;
            _mediator = mediator;
            PressDataGridViewTable.AutoGenerateColumns = false;
            runMain();
        }
        private void FormDetailList_Shown(object? sender, EventArgs e)
        {
            //窗体打开时先取消事件绑定
            //防止每次打开数据列表窗体时都重新绑定事件，导致重复绑定
            PressDataGridViewTable.CellPainting -= dataGridView1_CellPainting;
            PressDataGridViewTable.CellPainting += dataGridView1_CellPainting;
            PressDataGridViewTable.CellClick -= dataGridView1_CellClick;
            PressDataGridViewTable.CellClick += dataGridView1_CellClick;
        }

        private void runMain()
        {
            //将当前DataListView注册到面板注册表中
            _panelRegistry.RegisterListView("PressDataGridViewTable", new UpdateListViewService(PressDataGridViewTable));
        }
    

        // 根据不同的状态设置不同的按钮颜色和文本
        private void dataGridView1_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            int buttonColIndex = 4;
            if (e.ColumnIndex == buttonColIndex && e.RowIndex >= 0)
            {
                var row = PressDataGridViewTable.Rows[e.RowIndex];
                if (row?.DataBoundItem is not PressDetailDto dto) return;

                Color backColor = Color.LightGray;
                string text = "操作";
                Color textColor = Color.Black;

                switch (dto.State)
                {
                    case AcquistionState.Sucess:
                        backColor = Color.LightBlue;
                        text = "已完成";
                        textColor = Color.Gray;
                        break;
                    case AcquistionState.Failed:
                        backColor = Color.LightCoral;
                        text = "重试";
                        textColor = Color.White;
                        break;
                    default:
                        backColor = Color.LightGray;
                        text = "未知状态";
                        textColor = Color.Gray;
                        break;
                }

                e.PaintBackground(e.CellBounds, true);
                if (e.Graphics != null)
                {
                    using (Brush b = new SolidBrush(backColor))
                    {
                        e.Graphics.FillRectangle(b, e.CellBounds);
                    }

                    if (!string.IsNullOrEmpty(text) && e.CellStyle?.Font != null)
                    {
                        TextRenderer.DrawText(e.Graphics, text, e.CellStyle.Font, e.CellBounds, textColor,
                            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                    }
                }
                e.Handled = true;
            }
        }
       
        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            int buttonColIndex = 4;

            if (e.RowIndex >= 0 && e.ColumnIndex == buttonColIndex)
            {
                var dto = PressDataGridViewTable.Rows[e.RowIndex].DataBoundItem as PressDetailDto;

                if (dto == null)
                {
                    return;
                }

                if (dto.State == AcquistionState.Sucess)
                {
                    // 已完成操作禁用点击操作
                    return;
                }

                var failFileSourceDirectory = new DirectoryInfo(dto.FailFileSource ?? string.Empty);
                _ = _mediator.Send(new RetrySingeFileReadCommand("press", GlobalData.TotalCount, GlobalData.SuccessCount, GlobalData.FailedCount, failFileSourceDirectory));
          
                PressDataGridViewTable.Refresh();            
            }
        }
    }
}
