using BitBasket.Core.ServiceContracts;
using BitBasket.Core.Services;
using BitBasket.Core.Validator;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBasket.Core
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Add core services to the Ioc container
        /// </summary>
        /// <param name="services"></param>
        /// <returns>serviceCollection</returns>
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddValidatorsFromAssemblyContaining<LoginRequestValidator>();
            return services;
        }
    }
}
