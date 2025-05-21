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
            //��ʼ�����ò���
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
            //ע�ᴰ�����
            services.AddSingleton<Form1>();
            //ע����־����
            services.AddCustomLogger(GlobalData.LogPath, GlobalData.Params.LogRetentionDays);

            //�ַ�֪ͨ
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(AcquisitionProgressSuccessNotification).Assembly));
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(AcquisitionProgressFailedNotification).Assembly));
            
            services.AddSingleton<IPanelRegistry, PanelRegistry>();
        }
    }
}