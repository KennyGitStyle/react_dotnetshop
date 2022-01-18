using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace API.Extensions
{
    public static class ConfigurationServiceExtension
    {
        public static IServiceCollection ServicesConfigurationExtensions(this IServiceCollection services){
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
            });

            return services;

        }
    }
}