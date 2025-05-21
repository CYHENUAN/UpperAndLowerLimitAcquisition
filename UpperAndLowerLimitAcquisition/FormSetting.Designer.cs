namespace UpperAndLowerLimitAcquisition
{
    partial class FormSetting
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
            tableLayoutPanel1 = new TableLayoutPanel();
            propertyGrid1 = new PropertyGrid();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(propertyGrid1, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel1.Size = new Size(420, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // propertyGrid1
            // 
            propertyGrid1.Dock = DockStyle.Fill;
            propertyGrid1.HelpVisible = false;
            propertyGrid1.Location = new Point(3, 3);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new Size(414, 408);
            propertyGrid1.TabIndex = 0;
            propertyGrid1.ToolbarVisible = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Dock = DockStyle.Right;
            button1.Font = new Font("黑体", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button1.Location = new Point(342, 417);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 1;
            button1.Text = "保存设置";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FormSetting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "参数配置";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PropertyGrid propertyGrid1;
        private Button button1;
    }
}