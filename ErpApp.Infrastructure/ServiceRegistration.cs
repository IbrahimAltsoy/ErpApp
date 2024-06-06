using ErpApp.Application.Services;
using ErpApp.Application.Services.HubService;
using ErpApp.Infrastructure.Services;
using ErpApp.Infrastructure.Services.Hubs;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpApp.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<ICreateUserHubService, CreateUserHubService>();

            services.AddSignalR();

        }
    }
}
