using Eventify_OnionArchitecture.Application.Abstractions.Services;
using Eventify_OnionArchitecture.Persistence.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Eventify_OnionArchitecture.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<AppDbContext>();
        }
    }
}
