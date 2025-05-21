using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpperAndLowerLimitAcquisition.Services;

namespace UpperAndLowerLimitAcquisition.Controls
{
    public class ControlsService : Form
    {
        //动态生成设备概览布局
        public Control DeviceDynamicLayout()
        {
            var ls = new DeviceInfoService().GetDeviceType();
            var table = new TableLayoutPanel();
            table.Dock = DockStyle.Fill;
            table.ColumnCount = ls.Count;
            table.RowCount = 1;
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            table.ColumnStyles.Clear();

            for (int i = 0; i < ls.Count; i++)
            {
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / table.ColumnCount));
                var panel = new Panel();
                panel.Dock = DockStyle.Fill;
                panel.BackColor = Color.FromArgb(50 + i * 40, 100, 200);
                var innerTable = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    ColumnCount = 3,
                    RowCount = 2
                };
                innerTable.SuspendLayout();
                innerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45f));
                innerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10f));
                innerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45f));
                innerTable.RowStyles.Add(new RowStyle(SizeType.Percent, 28f));
                innerTable.RowStyles.Add(new RowStyle(SizeType.Percent, 72f));

                // 设备名称Label
                var label = CreateLabel(
                    ls[i].DeviceName + "：",
                    DockStyle.Fill,
                    ContentAlignment.MiddleCenter,
                    new Font("黑体", 12F, FontStyle.Bold),
                    Color.White,
                    Color.FromArgb(255, 141, 122)
                );
                innerTable.Controls.Add(label, 0, 0);
                innerTable.SetColumnSpan(label, 2);

                // 总数量Label
                var label2 = CreateLabel(
                    ls[i].DevicesTotalQuantity.ToString(),
                    DockStyle.Fill,
                    ContentAlignment.MiddleCenter,
                    new Font("黑体", 15F, FontStyle.Bold),
                    Color.White,
                    Color.FromArgb(255, 141, 122)
                );
                innerTable.Controls.Add(label2, 2, 0);

                // 正常运行数量Label
                var label3 = CreateLabel(
                    ls[i].DeviceNormalOperation.ToString("00"),
                    DockStyle.Fill,
                    ContentAlignment.MiddleCenter,
                    new Font("黑体", 26F, FontStyle.Bold),
                    Color.LimeGreen
                );
                innerTable.Controls.Add(label3, 0, 1);

                // 分隔符Label
                var label4 = CreateLabel(
                    "|",
                    DockStyle.Fill,
                    ContentAlignment.MiddleCenter,
                    new Font("黑体", 12F, FontStyle.Bold),
                    Color.White
                );
                innerTable.Controls.Add(label4, 1, 1);

                // 故障数量Label
                var label5 = CreateLabel(
                    ls[i].DeviceFaultCount.ToString("00"),
                    DockStyle.Fill,
                    ContentAlignment.MiddleCenter,
                    new Font("黑体", 26F, FontStyle.Bold),
                    Color.Red
                );
                innerTable.Controls.Add(label5, 2, 1);

                innerTable.ResumeLayout();
                panel.Controls.Add(innerTable);
                table.Controls.Add(panel, i, 0);
            }
            return table;
            
        }
        //创建Label标签
        private Label CreateLabel(string text, DockStyle dock, ContentAlignment align, Font font, Color foreColor, Color? backColor = null, Padding? margin = null)
        {
            return new Label
            {
                Text = text,
                Dock = dock,
                TextAlign = align,
                Font = font,
                ForeColor = foreColor,
                BackColor = backColor ?? Color.Transparent,
                Margin = margin ?? new Padding(0)
            };
        }

    }
}
