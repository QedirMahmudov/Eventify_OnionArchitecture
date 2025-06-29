using Eventify_OnionArchitecture.Application.Abstractions.Services;
using Eventify_OnionArchitecture.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Eventify_OnionArchitecture.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<ITextService, TextService>();
        }
    }
}
