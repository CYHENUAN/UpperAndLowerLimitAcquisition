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
            // Initialize settings parameters
            GlobalData.initParams();

            // Ensure GlobalData.LogPath and GlobalData.Params are not null
            if (string.IsNullOrEmpty(GlobalData.LogPath))
            {
                throw new InvalidOperationException("GlobalData.LogPath cannot be null or empty.");
            }

            if (GlobalData.Params == null)
            {
                throw new InvalidOperationException("GlobalData.Params cannot be null.");
            }

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