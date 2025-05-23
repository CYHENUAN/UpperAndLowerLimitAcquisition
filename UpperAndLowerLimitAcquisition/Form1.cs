using System.Threading.Tasks;
using MediatR;
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
        public CancellationToken token = new CancellationToken();
        public readonly LogService _logService;
        public readonly AcquisitionService _acquisitionService;
        private CancellationTokenSource? _mainTaskCts;
        private Task? _mainTask;

        public Form1(LogService logService, AcquisitionService acquisitionService, IPanelRegistry registry)
        {
            InitializeComponent();
            _logService = logService;
            _logService.GetListView(listView1);
            _acquisitionService = acquisitionService;
            _registry = registry;
            //��̬����豸��������־����б���� 
            DevicePanel.Controls.Add(new ControlsService().DeviceDynamicLayout());
            AdjustListViewColumns();
        }
        private void Form_Shown(object sender, EventArgs e)
        {
            // ����ѹ�������߳�
            //StartPressTaskThread();
        }
        // �������������������߳�
        private void StartPressTaskThread()
        {
            _mainTaskCts = new CancellationTokenSource();
            _mainTask = Task.Run(async () =>
            {
                while (!_mainTaskCts.Token.IsCancellationRequested)
                {
                    try
                    {
                        await pressRunMain();
                    }
                    catch (Exception ex)
                    {
                        _logService.AddMsg("System", 1, $"ѹ�������߳��쳣: {ex.Message}");
                    }
                    if (GlobalData.Params != null)
                    {
                        await Task.Delay(1000 * 60 * 60 * GlobalData.Params.PressReadFrequency, _mainTaskCts.Token);
                    }
                    else
                    {
                        _logService.PressLog(2, "GlobalData.Params is null, unable to read frequency.");
                    }

                }
            }, _mainTaskCts.Token);
        }

        // �� MainForm_FormClosing �¼������ȡ�������̵߳��߼�
        private async void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isClosing)
                return;
            e.Cancel = true;
            _isClosing = true;

            // ȡ�������߳�
            _mainTaskCts?.Cancel();
            try
            {
                if (_mainTask != null)
                    await _mainTask;
            }
            catch (OperationCanceledException) { }

            var closingForm = new ClosingForm();
            closingForm.Show(this);

            await Task.Run(() =>
            {
                if (_logService is IDisposable disposable)
                    disposable.Dispose();
            });
            closingForm.Close();
            Close();
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

        private async Task pressRunMain()
        {
            // ���������ж��Ƿ�����ѹ���ɼ�  
            if (GlobalData.Params != null && GlobalData.Params.PressIsEnable == IsEnable.True)
            {
                // ��ȡ��Ҫ���µ�Label  
                if (GlobalData.LabelUpdates.TryGetValue("ѹ������", out UpdateLabelClass? uplbl) && uplbl != null)
                {
                    // ȷ�� Label ����Ϊ null  
                    if (uplbl.LblTotal != null && uplbl.LabelSucess != null && uplbl.LabelFailed != null)
                    {
                        // �ֶ����� Label ӳ�䲢ע��  
                        _registry.RegisterPanel("press",
                            new PanelUpdateProxy("press", uplbl.LblTotal, uplbl.LabelSucess, uplbl.LabelFailed));
                    }
                    else
                    {
                        // ���� Label Ϊ null ��������ɸ��������¼��־���׳��쳣��  
                        _logService.PressLog(2, "One or more Label objects are null in UpdateLabelClass.");
                    }
                }

                // ȷ�� PressFilePath ��Ϊ null  
                if (!string.IsNullOrEmpty(GlobalData.Params.PressFilePath))
                {
                    await _acquisitionService.ReadAllFilesAsync(GlobalData.Params.PressFilePath, token);
                }
                else
                {
                    // ���� PressFilePath Ϊ null ��յ�������ɸ��������¼��־���׳��쳣��  
                    _logService.PressLog(2, "PressFilePath is null or empty in ParamsSetting.");
                }
            }
        }

        // ����Log�����ʽ
        public void test()
        {
            for (var i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    _logService.AddMsg("Press", 2, "����һ��������־���");
                }
                else
                {
                    _logService.AddMsg("Air", 1, "����һ��������־���");
                }
                Thread.Sleep(1000);
            }
        }

        //������ҳ��
        private void button1_Click(object sender, EventArgs e)
        {
            FormDetailList formDetailList = new FormDetailList();
            formDetailList.ShowDialog();
        }
    }
}
