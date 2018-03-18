using System;
using Microsoft.Extensions.DependencyInjection;
using Employees.Services;
using AutoMapper;
using Employees.Data;
using Microsoft.EntityFrameworkCore;

namespace Employees.Client
{
    class StartUp
    {
        static void Main()
        {
            IServiceProvider serviceProvider = ConfigureServices();

            Engine engine = new Engine(serviceProvider);

            engine.Run();
        }

        public static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContext<EmployeesContext>
                (options => options.UseSqlServer(Configuration.ConnectionString));

            serviceCollection.AddTransient<DbInitializerService>(); //, DbInitializerService>();

            serviceCollection.AddTransient<EmployeeService>();

            serviceCollection.AddAutoMapper(cfg => cfg.AddProfile<AutomapperProfile>());

            return serviceCollection.BuildServiceProvider();
        }
    }
}
// Install-Package Microsoft.EntityFrameworkCore.SqlServer
// Install-Package Microsoft.EntityFrameworkCore.Tools
// Install-Package Microsoft.Extensions.DependencyInjection
// Install-Package AutoMapper
// Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection

// Update-Database
// Drop-Database
// Add-Migration Initial
// Remove-Migration
// Update-Database -Migration: "Initial"