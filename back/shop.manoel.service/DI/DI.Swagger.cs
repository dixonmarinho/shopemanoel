using Microsoft.Extensions.DependencyInjection;

namespace shop.manoel.service.DI
{
    public static partial class DI
    {
        public static IServiceCollection AddSwaggerService(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            return services;
        }
    }
}
