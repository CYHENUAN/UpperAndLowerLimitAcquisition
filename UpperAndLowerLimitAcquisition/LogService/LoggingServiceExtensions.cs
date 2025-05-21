using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace UpperAndLowerLimitAcquisition.Log
{
    public static class LoggingServiceExtensions
    {
        public static IServiceCollection AddCustomLogger(this IServiceCollection services, string logBasePath = "Logs",int LogRetentionDays = 30)
        {
            services.AddSingleton<ICustomLoggerService>(_ => new CustomLoggerService(logBasePath, LogRetentionDays));
            return services;
        }
    }
}
