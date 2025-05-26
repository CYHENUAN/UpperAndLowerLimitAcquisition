using System.Text;
using Acquisition.IService;
using Acquisition.Service;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using UpperAndLowerLimitAcquisition.Equipment.Press;
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
            //注册编码提供程序
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
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
            services.AddSingleton<FormDetailList>();
            services.AddSingleton<LogService>();
            services.AddSingleton<AcquisitionService>();
            services.AddSingleton<ILabelPanelUpdater, PanelUpdateProxy>();
            services.AddSingleton<IPanelRegistry, PanelRegistry>();
            //注册检测项更新服务
            services.AddScoped<IUpdateRecipeService, UpdateRecipeService>();
            //注册压机服务
            services.AddSingleton<PressService>();
            // ICustomLoggerService 注册
            if (GlobalData.LogPath != null && GlobalData.Params != null)
            {
                services.AddCustomLogger(GlobalData.LogPath, GlobalData.Params.LogRetentionDays);
            }
            else
            {
                throw new InvalidOperationException("GlobalData.LogPath or GlobalData.Params cannot be null.");
            }
            // MediatR 配置
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssemblyContaining<AcquisitionProgressSuccessNotification>();
                config.RegisterServicesFromAssemblyContaining<AcquisitionProgressFailedNotification>();
                config.RegisterServicesFromAssemblyContaining<RetryAllFileReadCommand>();
                config.RegisterServicesFromAssemblyContaining<RetrySingeFileReadCommand>();
            });

            // 注册进度通知处理器（同一个 handler 处理两个通知）
            services.AddSingleton<INotificationHandler<AcquisitionProgressSuccessNotification>, AcquisitionProgressHandler>();
            services.AddSingleton<INotificationHandler<AcquisitionProgressFailedNotification>, AcquisitionProgressHandler>();
            services.AddSingleton<IRequestHandler<RetryAllFileReadCommand, Unit>, RetryFileReadCommandHandler>();
            services.AddSingleton<IRequestHandler<RetrySingeFileReadCommand, Unit>, RetryFileReadCommandHandler>();          
        }   
    }
}