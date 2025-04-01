using GloboTicket.TicketManagement.Application.Contracts.Infrastructure;
using Microsoft.Extensions.DependencyInjection;


namespace GloboTicket.TicketManagement.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
            
            // Registrar ICsvExporter
            //services.AddTransient<ICsvExporter, CsvExporter>(); // Reemplaza CsvExporter con tu implementación


            return services;
        }
    }
}