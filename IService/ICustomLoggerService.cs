using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acquisition.Common;

namespace Acquisition.IService
{
    public interface ICustomLoggerService
    {
        void Log(string category, LogLevel level, string message);

        void Info(string category, string message);

        void Warn(string category, string message);

        void Error(string category, string message);
       
    }
}
