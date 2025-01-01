using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PatientCare.Interfaces;
using PatientCare.Services;

namespace PatientCare
{
    public static class ServiceCollectionExtention
    {
        public static IConfiguration Configuration { get; private set; }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();

            services.AddSingleton<IDatabaseService, DatabaseService>();
            services.AddSingleton<IConfiguration>(Configuration);

            return services;
        }
    }
}