using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using shop.manoel.shared.Models;

namespace shop.manoel.service.DI
{
    public static partial class DI
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services)
        {
            services
                .AddIdentity<ApplicationUser, IdentityRole>()
                .AddDefaultTokenProviders();
            return services;
        }
    }
}
