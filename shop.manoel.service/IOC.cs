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
                .AddCustomCors()
                .ChangeCulture()
                .AddGeneralServices()
                .AddSwaggerService()
                .AddLogService()
                //.AddIdentityServices()
                .AddShopService()
                // Ativando o MVC
                .AddAuth();

            services.AddControllers();
            return services;
        }
    }
}
