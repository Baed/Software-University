using IdentityDemo.Web.Data;
using IdentityDemo.Web.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityDemo.Web.Infrastructures.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseDatabaseMigration(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<DemoIdentityDbContext>();

                context.Database.Migrate();

                var userManager = serviceScope
                     .ServiceProvider
                     .GetService<UserManager<User>>();

                var roleManager = serviceScope
                    .ServiceProvider
                    .GetService<RoleManager<IdentityRole>>();

                Task
                    .Run(async () =>
                {
                    var adminRole = GlobalConstants.AdministatorRole;

                    bool roleExists = await roleManager.RoleExistsAsync(adminRole);

                    if (!roleExists)
                    {
                        await roleManager.CreateAsync(new IdentityRole
                        {
                            Name = adminRole
                        });
                    }

                    var adminEmail = "admin@mysite.com";

                    var adminUser = await userManager.FindByNameAsync(adminEmail);

                    if (adminUser == null)
                    {
                        adminUser = new User
                        {
                            Email = adminEmail,
                            UserName = adminEmail
                        };

                        await userManager.CreateAsync(adminUser, "admin123");

                        await userManager.AddToRoleAsync(adminUser, adminRole);
                    }
                })
                .GetAwaiter()
                .GetResult();
            }

            return app;
        }
    }
}
