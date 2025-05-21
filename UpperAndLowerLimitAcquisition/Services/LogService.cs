using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acquisition.IService;
using UpperAndLowerLimitAcquisition.Model;

namespace UpperAndLowerLimitAcquisition.Services
{
    public class LogService
    {
        public readonly ICustomLoggerService _loggerService;
        private static ConcurrentQueue<Msg> msgQueue = new ConcurrentQueue<Msg>();
        Thread thread;     
        private ListView Ls { get; set; }
        public LogService(ICustomLoggerService loggerService,ListView listView)
        {
            _loggerService = loggerService;
            Ls = listView;
            thread = new Thread(WriteLog)
            {
                IsBackground = true
            };
            thread.Start();
        }
    
        public void AddMsg(string cg, int index, string str)
        {
            Msg msg = new Msg(cg, index, str);
            msgQueue.Enqueue(msg);
        }
        public void WriteLog()
        {
            while (true)
            {
                if (!msgQueue.IsEmpty)
                {
                    Msg msg = null;
                    msgQueue.TryDequeue(out msg);
                    AddLog(msg.category, msg.index, msg.str);
                    //SaveLog(msg.str);
                }
                else
                {
                    Thread.Sleep(1);
                }
            }
        }

        private void AddLog(string category, int index, string info)
        {
            if (!Ls.InvokeRequired)
            {
                if (Ls.Items.Count > 500)
                {
                    Ls.Items.Clear();
                }
                ListViewItem Lvi = new ListViewItem("  " + DateTime.Now.ToString("HH:mm:ss"), index);
                switch (index)
                {
                    case 0:
                        _loggerService.Info(category, info);
                        break;
                    case 1:
                        _loggerService.Warn(category, info);
                        Lvi.BackColor = Color.Yellow;
                        break;
                    case 2:
                        _loggerService.Error(category, info);
                        Lvi.BackColor = Color.Red;
                        break;
                }
                Lvi.SubItems.Add(info);
                if (Ls.IsHandleCreated)
                {
                    Ls.BeginInvoke(new Action(() =>
                    {
                        Ls.Items.Insert(0, Lvi);
                    }));
                }                      
            }
            else
            {
                Ls.Invoke(new Action(() =>
                {
                    if (Ls.Items.Count > 500)
                    {
                        Ls.Items.Clear();
                    }
                    ListViewItem Lvi = new ListViewItem("  " + DateTime.Now.ToString("HH:mm:ss"), index);
                    switch (index)
                    {
                        case 0:
                            _loggerService.Info(category, info);
                            break;
                        case 1:
                            _loggerService.Warn(category, info);
                            Lvi.BackColor = Color.Yellow;
                            break;
                        case 2:
                            _loggerService.Error(category, info);
                            Lvi.BackColor = Color.Red;
                            break;
                    }
                    Lvi.SubItems.Add(info);
                    if (Ls.IsHandleCreated)
                    {
                        Ls.BeginInvoke(new Action(() =>
                        {
                            Ls.Items.Insert(0, Lvi);
                        }));
                    }
                }));              
            }
        }


    }
}
