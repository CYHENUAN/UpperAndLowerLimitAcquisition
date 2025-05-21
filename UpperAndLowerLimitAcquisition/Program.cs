using MediatR;
using Microsoft.Extensions.DependencyInjection;
using UpperAndLowerLimitAcquisition.ISevices;
using UpperAndLowerLimitAcquisition.Log;
using UpperAndLowerLimitAcquisition.Model;
using UpperAndLowerLimitAcquisition.Services;

namespace UpperAndLowerLimitAcquisition
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           //初始化全局参数
            GlobalData.initParams();   

            //依赖注入服务
            var services = new ServiceCollection();
            ConfigureServices(services);

            ServiceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            var mainForm = ServiceProvider.GetRequiredService<Form1>();
            Application.Run(mainForm);
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            // Register form services
            services.AddSingleton<Form1>();

            // Register logging service
            if (GlobalData.LogPath != null && GlobalData.Params != null)
            {
                services.AddCustomLogger(GlobalData.LogPath, GlobalData.Params.LogRetentionDays);
            }
            else
            {
                throw new InvalidOperationException("GlobalData.LogPath or GlobalData.Params cannot be null.");
            }

            // Distribute notifications
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(AcquisitionProgressSuccessNotification).Assembly));
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(AcquisitionProgressFailedNotification).Assembly));

            services.AddSingleton<IPanelRegistry, PanelRegistry>();
        }
    }
}