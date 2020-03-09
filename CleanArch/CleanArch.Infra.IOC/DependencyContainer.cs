using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ICourseRepository, ICourseRepository>();
        }
    }
}
