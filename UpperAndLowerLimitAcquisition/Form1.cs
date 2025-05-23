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
            //动态添加设备概览及日志输出列表调整 
            DevicePanel.Controls.Add(new ControlsService().DeviceDynamicLayout());
            AdjustListViewColumns();
        }
        private void Form_Shown(object sender, EventArgs e)
        {
            // 启动压机任务线程
            //StartPressTaskThread();
        }
        // 新增方法：启动任务线程
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
                        _logService.AddMsg("System", 1, $"压机任务线程异常: {ex.Message}");
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

        // 在 MainForm_FormClosing 事件中添加取消任务线程的逻辑
        private async void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isClosing)
                return;
            e.Cancel = true;
            _isClosing = true;

            // 取消任务线程
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

        private async Task pressRunMain()
        {
            // 根据配置判定是否启用压机采集  
            if (GlobalData.Params != null && GlobalData.Params.PressIsEnable == IsEnable.True)
            {
                // 获取需要更新的Label  
                if (GlobalData.LabelUpdates.TryGetValue("压机数量", out UpdateLabelClass? uplbl) && uplbl != null)
                {
                    // 确保 Label 对象不为 null  
                    if (uplbl.LblTotal != null && uplbl.LabelSucess != null && uplbl.LabelFailed != null)
                    {
                        // 手动创建 Label 映射并注册  
                        _registry.RegisterPanel("press",
                            new PanelUpdateProxy("press", uplbl.LblTotal, uplbl.LabelSucess, uplbl.LabelFailed));
                    }
                    else
                    {
                        // 处理 Label 为 null 的情况（可根据需求记录日志或抛出异常）  
                        _logService.PressLog(2, "One or more Label objects are null in UpdateLabelClass.");
                    }
                }

                // 确保 PressFilePath 不为 null  
                if (!string.IsNullOrEmpty(GlobalData.Params.PressFilePath))
                {
                    await _acquisitionService.ReadAllFilesAsync(GlobalData.Params.PressFilePath, token);
                }
                else
                {
                    // 处理 PressFilePath 为 null 或空的情况（可根据需求记录日志或抛出异常）  
                    _logService.PressLog(2, "PressFilePath is null or empty in ParamsSetting.");
                }
            }
        }

        // 测试Log输出格式
        public void test()
        {
            for (var i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    _logService.AddMsg("Press", 2, "这是一条正常日志输出");
                }
                else
                {
                    _logService.AddMsg("Air", 1, "这是一条警告日志输出");
                }
                Thread.Sleep(1000);
            }
        }

        //打开详情页面
        private void button1_Click(object sender, EventArgs e)
        {
            FormDetailList formDetailList = new FormDetailList();
            formDetailList.ShowDialog();
        }
    }
}
