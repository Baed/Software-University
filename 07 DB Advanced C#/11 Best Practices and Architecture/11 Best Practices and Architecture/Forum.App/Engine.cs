using System;
using System.Linq;
using Forum.Data;
using Forum.Servises;
using Forum.Servises.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Forum.App
{
    public class Engine
    {
        private readonly IServiceProvider _serviceProvider;

        public Engine()
        {
            
        }

        public Engine(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Run()
        {
            var servceProviderRun = ConfigureServices();

            ConfigureDbService(servceProviderRun);
        }


        public void ExecuteCommand()
        {
            while (true)
            {
                Console.WriteLine("Enter command: ");

                string command = Console.ReadLine();

                var cmdTokens = command.Split(' ');

                var commandName = cmdTokens.First();

                var cmdArgs = cmdTokens.Skip(1).ToArray();

                try
                {
                    var input = CommandParser.ParseCommand(_serviceProvider, commandName);

                    var result = input.Execude(cmdArgs);

                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
        }

        private static void ConfigureDbService(IServiceProvider servceProviderRun)
        {
            var dbinitializeService = servceProviderRun.GetService<IDbInitializerService>();
            dbinitializeService.InitializeDb();
        }

        private static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContext<ForumDbContex>(options => options.UseSqlServer(Configuration.ConnectionString));

            serviceCollection.AddTransient<IDbInitializerService, DbInitializerService>();

            serviceCollection.AddTransient<IUserService, UserService>();

            serviceCollection.AddTransient<IPostService, PostService>();

            serviceCollection.AddTransient<ICategoryService, CategoryService>();

            serviceCollection.AddTransient<IReplyService, ReplyService>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
