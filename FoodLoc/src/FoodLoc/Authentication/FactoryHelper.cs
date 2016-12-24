using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodLoc.Repositories.Abstract;
using FoodLoc.Repositories.Impl;
using FoodLoc.Repositories.Infrastructure;
using FoodLoc.Services;
using FoodLoc.Services.Abstract;
using FoodLoc.Services.Impl;

namespace FoodLoc.API.Authentication
{
    public class FactoryHelper
    {
        public static void Create(IServiceCollection services)
        {
            // Add application services.
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRepository, UserRepository>();

            services.AddTransient<IPortfolioService, PortfolioService>();
            services.AddTransient<IPortfolioRepository, PortfolioRepository>();
            services.AddScoped<IDatabaseFactory, DatabaseFactory>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IConfigurationRoot, ConfigurationRoot>();
            services.AddTransient<ICompanyService, CompanyService>();
            services.AddTransient<ICompanyRepository, CompanyRepository>();

            services.AddTransient<IRoleTypeService, RoleTypeService>();
            services.AddTransient<IRoleTypeRepository, RoleTypeRepository>();
        }
    }
}
