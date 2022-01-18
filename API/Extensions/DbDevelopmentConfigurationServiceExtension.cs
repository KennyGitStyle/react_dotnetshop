using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public static class DbDevelopmentConfigurationServiceExtension
    {
        public static IServiceCollection
        DevelopmentDbContextExtension(
            this IServiceCollection services,
            IConfiguration config
        )
        {
            services
                .AddDbContext<StoreContext>(x =>
                    x
                        .UseSqlite(config
                            .GetConnectionString("DevelopmentConnection")));

            return services;
        }
    }
}
