using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PatientCare.Forms;
using PatientCare.Handlers;
using PatientCare.Interfaces;

namespace PatientCare
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.ThreadException += ExceptionHandler.HandleThreadException;
            AppDomain.CurrentDomain.UnhandledException += ExceptionHandler.HandleUnhandledException;

            var services = new ServiceCollection();
            services.AddServices();
            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            var mainForm = serviceProvider.GetRequiredService<Operations>();
            Application.Run(mainForm);
        }
    }
}
