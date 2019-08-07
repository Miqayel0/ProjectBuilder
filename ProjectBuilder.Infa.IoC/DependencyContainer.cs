using Microsoft.Extensions.DependencyInjection;
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
            // Application Layer
            // services.AddScoped<ICourseService, CourseService>();

            // Persistence Layer
            //services.AddScoped<ICourseRepository, CourseRepository>();

            services.AddScoped<ApplicationDbContext>();
        }
    }
}
