using MediatR;
using Microsoft.Extensions.DependencyInjection;
using UpperAndLowerLimitAcquisition.Extended;
using UpperAndLowerLimitAcquisition.ISevices;
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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //初始化设置参数
            GlobalData.initParams();
            var services = new ServiceCollection();
            ConfigureServices(services);

            ServiceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            var mainForm = ServiceProvider.GetRequiredService<Form1>();
            Application.Run(mainForm);
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            //注册窗体服务
            services.AddSingleton<Form1>();
            //注册日志服务
            services.AddCustomLogger(GlobalData.LogPath, GlobalData.Params.LogRetentionDays);

            //分发通知
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(AcquisitionProgressSuccessNotification).Assembly));
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(AcquisitionProgressFailedNotification).Assembly));
            
            services.AddSingleton<IPanelRegistry, PanelRegistry>();
        }
    }
}