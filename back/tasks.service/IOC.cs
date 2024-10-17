using Microsoft.Extensions.DependencyInjection;
using shop.manoel.service.DI;

namespace shop.manoel.service
{
    // Inversion Of Control - Inversao de Controle
    public static partial class IOC
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services
                .ChangeCulture()
                .AddGeneralServices()
                .AddAuthorization()
                .AddSwaggerService()
                .AddLogService()
                //.AddIdentityServices()
                .AddCustomCors()
                .AddShopService()

                // Ativando o MVC
                .AddControllers();

            return services;
        }
    }
}
