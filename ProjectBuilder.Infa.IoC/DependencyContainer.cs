using Microsoft.Extensions.DependencyInjection;
using ProjectBuilder.Application.Interfaces;
using ProjectBuilder.Application.Services;
using ProjectBuilder.Domain.Interfaces;
using ProjectBulder.Infa.Data.Auth;
using ProjectBulder.Infa.Data.Contexts;
using ProjectBulder.Infa.Data.Repositories;

namespace ProjectBuilder.Infa.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain Layer
            services.AddScoped<IJwtFactory, JwtFactory>();
            services.AddScoped<IProjectRepository, ProjectRepository > ();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Application Layer
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IProjectService, ProjectService>();

            // Persistence Layer
            services.AddScoped<ApplicationDbContext>();

        }
    }
}
