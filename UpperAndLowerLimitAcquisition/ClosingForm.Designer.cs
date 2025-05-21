namespace UpperAndLowerLimitAcquisition
{
    partial class ClosingForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblMessage;
        private ProgressBar progressBar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblMessage = new Label();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.Dock = DockStyle.Top;
            lblMessage.Font = new Font("微软雅黑", 12F);
            lblMessage.Location = new Point(0, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(262, 34);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "正在线程释放，请稍候…";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            progressBar.Dock = DockStyle.Bottom;
            progressBar.Location = new Point(0, 43);
            progressBar.MarqueeAnimationSpeed = 30;
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(262, 8);
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 1;
            // 
            // ClosingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 51);
            ControlBox = false;
            Controls.Add(progressBar);
            Controls.Add(lblMessage);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ClosingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "退出中";
            ResumeLayout(false);
        }
    }
}
