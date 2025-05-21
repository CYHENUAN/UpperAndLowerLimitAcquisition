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

            // UI ����  
            DevicePanel.Controls.Add(new ControlsService().DeviceDynamicLayout());
            AdjustListViewColumns();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // ����ʹ��  
            Task.Run(new Action(() =>
            {
                test();
            }));
            // ����ִ��  
            // runMain();  
        }

        // ��ʾ�������ý���  
        private void button2_Click(object sender, EventArgs e)
        {
            FormSetting formSetting = new FormSetting();
            formSetting.ShowDialog();
        }

        // ��Ļ��С�ı�ʱ��������־�б������е��п�  
        private void Form_Resize(object sender, EventArgs e)
        {
            AdjustListViewColumns();
        }

        // ������־�б������е��п�ʹ������Ӧ��Ļ  
        private void AdjustListViewColumns()
        {
            int totalWidth = listView1.ClientSize.Width;
            int col1Width = 120;
            int col2Width = totalWidth - col1Width - SystemInformation.VerticalScrollBarWidth;
            listView1.Columns[0].Width = col1Width;
            listView1.Columns[1].Width = col2Width < 0 ? 0 : col2Width;
        }

        // ����ر��¼�  
        private async void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isClosing)
                return;
            e.Cancel = true;
            _isClosing = true;

            var closingForm = new ClosingForm();
            closingForm.Show(this); // ��ʾģ̬��ʾ  

            await Task.Run(() =>
            {
                if (_customLoggerServic is IDisposable disposable)
                    disposable.Dispose(); // �ȴ���־����  
            });
            closingForm.Close(); // ��־��ɣ��ر���ʾ  
            Close(); // �����رմ���  
        }

        private void runMain()
        {
            // ��ȡ�����Ҫ���µ�Label  
            Label lblTotal_A = new Label();
            Label lblSuccess_A = new Label();
            Label lblFailed_A = new Label();
            // �ֶ����� Label ӳ�䲢ע��  
            _registry.RegisterPanel("����A",
                new PanelUpdateProxy("����A", lblTotal_A, lblSuccess_A, lblFailed_A));
        }

        public void test()
        {
            for (var i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    LogService.AddMsg("Press", 2, "����һ��������־���");
                }
                else
                {
                    LogService.AddMsg("Air", 1, "����һ��������־���");
                }
                Thread.Sleep(1000);
            }
        }
    }
}
