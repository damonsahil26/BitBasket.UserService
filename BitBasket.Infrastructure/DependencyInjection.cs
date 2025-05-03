using BitBasket.Core.RepositoryContracts;
using BitBasket.Infrastructure.DbContext;
using BitBasket.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBasket.Infrastructure
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Add infrastructure services to ioc container
        /// </summary>
        /// <param name="services"></param>
        /// <returns>Services</returns>
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<DapperDbContext>();
            return services;
        }
    }
}
