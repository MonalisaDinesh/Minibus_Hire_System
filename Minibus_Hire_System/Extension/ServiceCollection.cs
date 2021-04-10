using Microsoft.Extensions.DependencyInjection;
using Minibus_Hire_System.Interfaces;
using Minibus_Hire_System.Object;
using Minibus_Hire_System.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minibus_Hire_System.Extension
{
    public static class ServiceCollection
    {
        public static void AddServiceCollection(this IServiceCollection services)
        {
            services.AddScoped<IDatabaseService, DatabaseService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
