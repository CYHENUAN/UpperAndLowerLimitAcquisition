using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acquisition.Common;
using Acquisition.IService;
using Microsoft.Extensions.Logging.Abstractions;

namespace Acquisition.Service
{
    public class CustomLoggerService : ICustomLoggerService, IDisposable
    {
        private volatile bool _isDisposed = false;
        private readonly string _basePath;
        private readonly BlockingCollection<LogEntry> _logQueue = new();
        private readonly int _retentionDays;
        private readonly Task _loggingTask;
        private readonly Task _cleanupTask;
       // private readonly ReaderWriterLockSlim _lock = new ReaderWriterLockSlim();

        public CustomLoggerService(string basePath = "Logs", int retentionDays = 30)
        {
            _basePath = basePath;
            _retentionDays = retentionDays;

            // 启动后台任务
            _loggingTask = Task.Run(ProcessLogQueue);
            _cleanupTask = Task.Run(AutoCleanupOldLogs);
        }

        public void Info(string category, string message) => Log(category, LogLevel.Info, message);     
        public void Warn(string category, string message) => Log(category, LogLevel.Warning, message);      
        public void Error(string category, string message) => Log(category, LogLevel.Error, message);
        
        public void Log(string category, LogLevel level, string message)
        {
            //如果日志服务已被释放或日志队列已完成添加，则不再添加日志
            if (_isDisposed || _logQueue.IsAddingCompleted)
                return;

            var entry = new LogEntry
            {
                Category = category,
                Level = level,
                Timestamp = DateTime.Now,
                Message = message
            };
            try
            {
                _logQueue.TryAdd(entry, millisecondsTimeout: 100);
            }
            catch (Exception ex)
            {
                Console.WriteLine("日志添加失败：" + ex.Message);
            }
        }
        private async Task ProcessLogQueue()
        {         
            foreach (var entry in _logQueue.GetConsumingEnumerable())
            {
                try
                {                  
                    string dir = Path.Combine(_basePath, entry.Category ?? "默认", entry.Level.ToString(), $"{entry.Timestamp:yyyy-MM-dd}");
                    Directory.CreateDirectory(dir);

                    string file = Path.Combine(dir, "log.txt");
                    string line = $"[{entry.Timestamp:yyyy-MM-dd HH:mm:ss}] {entry.Message}";

                    await File.AppendAllTextAsync(file, line + Environment.NewLine, Encoding.UTF8);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("日志写入异常：" + ex.Message);
                }
            }
        }
        private async Task AutoCleanupOldLogs()
        {
            while (!_isDisposed)
            {
                try
                {
                    if (Directory.Exists(_basePath))
                    {
                        foreach (var dir in Directory.GetDirectories(_basePath, "*", SearchOption.AllDirectories))
                        {
                            var info = new DirectoryInfo(dir);
                            if (DateTime.TryParse(info.Name, out var dateDir))
                            {
                                if ((DateTime.Now - dateDir).TotalDays > _retentionDays)
                                {
                                    Directory.Delete(dir, true);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("日志清理异常：" + ex.Message);
                }

                await DelayWithCheck(TimeSpan.FromHours(12)); // 每 12 小时清理一次
            }
        }

        private async Task DelayWithCheck(TimeSpan delay, int checkIntervalMs = 1000)
        {
            int waited = 0;
            int total = (int)delay.TotalMilliseconds;

            while (waited < total && !_isDisposed)
            {
                await Task.Delay(checkIntervalMs);
                waited += checkIntervalMs;
            }
        }
        public void Dispose()
        {
            _isDisposed = true;
            _logQueue.CompleteAdding();
            try
            {
                Task.WaitAll(_loggingTask, _cleanupTask);
            }
            catch (AggregateException ex)
            {
                foreach (var inner in ex.InnerExceptions)
                {
                    Console.WriteLine("日志后台任务异常：" + inner.Message);
                }
            }         
        }
    }
}
