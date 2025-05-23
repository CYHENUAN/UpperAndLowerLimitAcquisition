namespace UpperAndLowerLimitAcquisition
{
    partial class FormDetailList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            PressDataGridViewTable = new DataGridView();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            StationName = new DataGridViewTextBoxColumn();
            EquimentName = new DataGridViewTextBoxColumn();
            FailFileSource = new DataGridViewTextBoxColumn();
            Icon = new DataGridViewImageColumn();
            Retry = new DataGridViewButtonColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PressDataGridViewTable).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 420);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "压机列表";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(PressDataGridViewTable, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
            tableLayoutPanel1.Size = new Size(786, 414);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("黑体", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(707, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(79, 20);
            button1.TabIndex = 0;
            button1.Text = "一键重试";
            button1.UseVisualStyleBackColor = false;
            // 
            // PressDataGridViewTable
            // 
            PressDataGridViewTable.AllowUserToAddRows = false;
            PressDataGridViewTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            PressDataGridViewTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            PressDataGridViewTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PressDataGridViewTable.Columns.AddRange(new DataGridViewColumn[] { StationName, EquimentName, FailFileSource, Icon, Retry });
            tableLayoutPanel1.SetColumnSpan(PressDataGridViewTable, 2);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            PressDataGridViewTable.DefaultCellStyle = dataGridViewCellStyle3;
            PressDataGridViewTable.Dock = DockStyle.Fill;
            PressDataGridViewTable.Location = new Point(3, 23);
            PressDataGridViewTable.Name = "PressDataGridViewTable";
            PressDataGridViewTable.RowHeadersVisible = false;
            PressDataGridViewTable.Size = new Size(780, 388);
            PressDataGridViewTable.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 420);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "拧紧枪列表";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 420);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "气密列表";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // StationName
            // 
            StationName.DataPropertyName = "StationName";
            StationName.FillWeight = 50F;
            StationName.HeaderText = "工位";
            StationName.Name = "StationName";
            // 
            // EquimentName
            // 
            EquimentName.DataPropertyName = "EquimentName";
            EquimentName.FillWeight = 50F;
            EquimentName.HeaderText = "设备编号";
            EquimentName.Name = "EquimentName";
            // 
            // FailFileSource
            // 
            FailFileSource.DataPropertyName = "FailFileSource";
            FailFileSource.FillWeight = 180F;
            FailFileSource.HeaderText = "数据来源";
            FailFileSource.Name = "FailFileSource";
            // 
            // Icon
            // 
            Icon.DataPropertyName = "Icon";
            Icon.FillWeight = 40F;
            Icon.HeaderText = "状态";
            Icon.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Icon.Name = "Icon";
            Icon.Resizable = DataGridViewTriState.True;
            Icon.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Retry
            // 
            Retry.DataPropertyName = "Retry";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(192, 192, 255);
            Retry.DefaultCellStyle = dataGridViewCellStyle2;
            Retry.FillWeight = 50F;
            Retry.HeaderText = "操作";
            Retry.Name = "Retry";
            Retry.Resizable = DataGridViewTriState.True;
            Retry.SortMode = DataGridViewColumnSortMode.Automatic;
            Retry.Text = "";
            // 
            // FormDetailList
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FormDetailList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "数据列表";
            Shown += FormDetailList_Shown;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PressDataGridViewTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private DataGridView PressDataGridViewTable;
        private DataGridViewTextBoxColumn StationName;
        private DataGridViewTextBoxColumn EquimentName;
        private DataGridViewTextBoxColumn FailFileSource;
        // Add the 'new' keyword to explicitly hide the inherited member 'Form.Icon'
        private new DataGridViewImageColumn Icon;
        private DataGridViewButtonColumn Retry;
    }
}