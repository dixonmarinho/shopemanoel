using Microsoft.Extensions.DependencyInjection;
using shop.manoel.service.Services;
using shop.manoel.shared.Interfaces;

namespace shop.manoel.service.DI
{
    public partial class DI
    {
        public static IServiceCollection AddShopService(this IServiceCollection services)
        {
            services
                .AddScoped<IServiceOrder, ServiceOrder>()
                ;
            return services;
        }

    }
}
