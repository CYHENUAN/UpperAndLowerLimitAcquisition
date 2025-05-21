using Microsoft.Extensions.DependencyInjection;
using Microsoft.Win32;
using UpperAndLowerLimitAcquisition.Controls;
using UpperAndLowerLimitAcquisition.Helper;
using UpperAndLowerLimitAcquisition.ISevices;
using UpperAndLowerLimitAcquisition.Log;
using UpperAndLowerLimitAcquisition.Model;
using UpperAndLowerLimitAcquisition.Services;

namespace UpperAndLowerLimitAcquisition
{
    public partial class Form1 : Form
    {
        private readonly IPanelRegistry _registry;
        private bool _isClosing = false;
        public LogService LogService { get; private set; }  
        public readonly ICustomLoggerService _customLoggerServic;

        public Form1(ICustomLoggerService customLoggerServic, IPanelRegistry registry)
        {
            InitializeComponent();
            _customLoggerServic = customLoggerServic ?? throw new ArgumentNullException(nameof(customLoggerServic));
            _registry = registry ?? throw new ArgumentNullException(nameof(registry));

            // Initialize LogService  
            LogService = new LogService(_customLoggerServic, this.listView1);

            // UI 更新  
            DevicePanel.Controls.Add(new ControlsService().DeviceDynamicLayout());
            AdjustListViewColumns();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // 测试使用  
            Task.Run(new Action(() =>
            {
                test();
            }));
            // 程序执行  
            // runMain();  
        }

        // 显示参数设置界面  
        private void button2_Click(object sender, EventArgs e)
        {
            FormSetting formSetting = new FormSetting();
            formSetting.ShowDialog();
        }

        // 屏幕大小改变时，调整日志列表内容列的列宽  
        private void Form_Resize(object sender, EventArgs e)
        {
            AdjustListViewColumns();
        }

        // 调整日志列表内容列的列宽，使其自适应屏幕  
        private void AdjustListViewColumns()
        {
            int totalWidth = listView1.ClientSize.Width;
            int col1Width = 120;
            int col2Width = totalWidth - col1Width - SystemInformation.VerticalScrollBarWidth;
            listView1.Columns[0].Width = col1Width;
            listView1.Columns[1].Width = col2Width < 0 ? 0 : col2Width;
        }

        // 窗体关闭事件  
        private async void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isClosing)
                return;
            e.Cancel = true;
            _isClosing = true;

            var closingForm = new ClosingForm();
            closingForm.Show(this); // 显示模态提示  

            await Task.Run(() =>
            {
                if (_customLoggerServic is IDisposable disposable)
                    disposable.Dispose(); // 等待日志处理  
            });
            closingForm.Close(); // 日志完成，关闭提示  
            Close(); // 真正关闭窗体  
        }

        private void runMain()
        {
            // 获取面板需要更新的Label  
            Label lblTotal_A = new Label();
            Label lblSuccess_A = new Label();
            Label lblFailed_A = new Label();
            // 手动创建 Label 映射并注册  
            _registry.RegisterPanel("任务A",
                new PanelUpdateProxy("任务A", lblTotal_A, lblSuccess_A, lblFailed_A));
        }

        public void test()
        {
            for (var i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    LogService.AddMsg("Press", 2, "这是一条正常日志输出");
                }
                else
                {
                    LogService.AddMsg("Air", 1, "这是一条警告日志输出");
                }
                Thread.Sleep(1000);
            }
        }
    }
}
