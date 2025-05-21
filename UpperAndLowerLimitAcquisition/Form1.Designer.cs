using System.Windows.Forms;

namespace UpperAndLowerLimitAcquisition
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            time = new ColumnHeader();
            content = new ColumnHeader();
            imageList1 = new ImageList(components);
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            DevicePanel = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 2, 0);
            tableLayoutPanel1.Controls.Add(DevicePanel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox1, 3);
            groupBox1.Controls.Add(listView1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("黑体", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            groupBox1.Location = new Point(5, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(790, 359);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "日志";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { time, content });
            listView1.Dock = DockStyle.Fill;
            listView1.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            listView1.HeaderStyle = ColumnHeaderStyle.None;
            listView1.Location = new Point(3, 17);
            listView1.Name = "listView1";
            listView1.Size = new Size(784, 339);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // time
            // 
            time.Width = 120;
            // 
            // content
            // 
            content.Width = 500;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Information.png");
            imageList1.Images.SetKeyName(1, "warn.png");
            imageList1.Images.SetKeyName(2, "error.png");
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(705, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(90, 73);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = SystemColors.InactiveCaption;
            button2.Font = new Font("黑体", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button2.Location = new Point(4, 40);
            button2.Name = "button2";
            button2.Size = new Size(82, 32);
            button2.TabIndex = 1;
            button2.Text = "参数设置";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Font = new Font("黑体", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button1.Location = new Point(4, 3);
            button1.Name = "button1";
            button1.Size = new Size(82, 32);
            button1.TabIndex = 0;
            button1.Text = "设备详情";
            button1.UseVisualStyleBackColor = false;
            // 
            // DevicePanel
            // 
            tableLayoutPanel1.SetColumnSpan(DevicePanel, 2);
            DevicePanel.Dock = DockStyle.Fill;
            DevicePanel.Location = new Point(5, 5);
            DevicePanel.Name = "DevicePanel";
            DevicePanel.Size = new Size(692, 73);
            DevicePanel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += MainForm_FormClosing;
            Load += Form_Load;
            Resize += Form_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListView listView1;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Panel DevicePanel;
        private ImageList imageList1;
        private ColumnHeader time;
        private ColumnHeader content;
    }
}
