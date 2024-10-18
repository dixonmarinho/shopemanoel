using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace shop.manoel.service.DI
{
    public static partial class DI
    {
        public static IServiceCollection AddSwaggerService(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Shop Manoel", Version = "v1" });

                // Configurar a segurança JWT no Swagger
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "Insira o token JWT no formato 'Bearer {seu token}'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                            //Scheme = "oauth2",
                            //Name = "Bearer",
                            //In = ParameterLocation.Header,
                        },
                        new List<string>()
                    }
                });
            });
            return services;
        }
    }
}
