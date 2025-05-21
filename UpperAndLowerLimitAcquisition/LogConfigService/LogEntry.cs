using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpperAndLowerLimitAcquisition.Model;

namespace UpperAndLowerLimitAcquisition.Log
{
    public class LogEntry
    {
        public string? Category { get; set; }
        public LogLevel Level { get; set; }
        public DateTime Timestamp { get; set; }
        public string? Message { get; set; }
    }
}
