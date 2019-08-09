using Microsoft.Extensions.DependencyInjection;
using ProjectBuilder.Application.Interfaces;
using ProjectBuilder.Application.Services;
using ProjectBuilder.Domain.Interfaces;
using ProjectBulder.Infa.Data.Auth;
using ProjectBulder.Infa.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBuilder.Infa.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain Layer
            services.AddScoped<IJwtFactory, JwtFactory>();

            // Application Layer
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IAuthService, AuthService>();

            // Persistence Layer
            services.AddScoped<ApplicationDbContext>();
        }
    }
}
