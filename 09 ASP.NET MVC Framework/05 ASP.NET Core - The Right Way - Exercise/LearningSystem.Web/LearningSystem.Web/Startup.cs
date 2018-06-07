using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using LearningSystem.Data;
using LearningSystem.Data.Models;
using AutoMapper;
using LearningSystem.Web.Infrastructure.ServiceCollections;
using LearningSystem.Web.Infrastructure.Identities;
using Microsoft.AspNetCore.Mvc;

namespace LearningSystem.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<LearningSystemDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //Configure custom password requirerment
            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;

            })
                .AddEntityFrameworkStores<LearningSystemDbContext>()
                .AddDefaultTokenProviders();

            //Configure service reflection
            services.AddDomainServices();

            //Configure ulrs
            services.AddRouting(routing => routing.LowercaseUrls = true);

            //Configure Automapper
            services.AddAutoMapper();

            //Configure global Antiforgery
            services.AddMvc(options =>
            {
                options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //custom extension method for db migrations
            app.UseDatabaseMigrationWithIdentities();

            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "profile",
                  template: "users/{username}",
                  defaults: new
                  {
                      controller = "Users",
                      action = "Profile"
                  });

                routes.MapRoute(
                  name: "blog",
                  template: "blog/articles/{id}/{title}",
                  defaults: new
                  {
                      area = "Blog",
                      controller = "Articles",
                      action = "Details"
                  });

                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                  name: "default",
                  template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
