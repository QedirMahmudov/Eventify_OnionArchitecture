using Eventify_OnionArchitecture.Application.Abstractions.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace Eventify_OnionArchitecture.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ExportService>();
        }
    }
}
