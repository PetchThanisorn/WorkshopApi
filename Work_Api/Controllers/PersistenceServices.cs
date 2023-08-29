using Microsoft.Extensions.DependencyInjection.Extensions;
using ReactAspWorkShop.BackEnd.View.Infrastructure;
using ReactAspWorkShop.BackEnd.View.Services;

namespace ReactAspWorkShop.Controllers
{
    public static class PersistenceServices
    {
        public static IServiceCollection GetServices(this IServiceCollection services) 
        {
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IManagedUserService, ManagedUserService>();
            return services;
        }
    }
}
