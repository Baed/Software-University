using LearningSystem.Constants;
using LearningSystem.Data;
using LearningSystem.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace LearningSystem.Web.Infrastructure.Identities
{
    public static class IdentitiesBuilderExtensions
    {
        public static IApplicationBuilder UseDatabaseMigrationWithIdentities(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope
                    .ServiceProvider
                    .GetService<LearningSystemDbContext>();

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
                        var adminRole = IdentitiesConstants.ADMINISTRATOR_ROLE;

                        var roles = new[]
                        {
                            adminRole,
                            IdentitiesConstants.AUTHOR_ROLE,
                            IdentitiesConstants.TRAINER_ROLE
                        };

                        foreach (var role in roles)
                        {
                            bool roleExists = await roleManager.RoleExistsAsync(role);

                            if (!roleExists)
                            {
                                await roleManager.CreateAsync(new IdentityRole
                                {
                                    Name = role
                                });
                            }
                        }

                        var adminEmail = "admin@mysite.com";

                        var adminUser = await userManager.FindByNameAsync(adminEmail);

                        if (adminUser == null)
                        {
                            adminUser = new User
                            {
                                Email = adminEmail,
                                UserName = adminRole,
                                Name = adminRole,
                                Birthday = DateTime.UtcNow
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
