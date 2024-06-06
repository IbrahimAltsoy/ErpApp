using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace ErpApp.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(ServiceRegistration));         
            services.AddHttpClient();

        }
    }
}
