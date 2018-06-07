using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Client
{
    public class Engine
    {
        private readonly IServiceProvider serviceProvider;

        public Engine(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void Run()
        {
            Console.WriteLine($"Application is running corectly!");

            while (true)
            {
                Console.WriteLine($"Enter command: ");

                var input = Console.ReadLine();

                var cmdArgs = input.Split();

                var commandName = cmdArgs[0];

                cmdArgs = cmdArgs.Skip(1).ToArray();

                var command = CommandParser.Parse(serviceProvider, commandName);

                var result = command.Execute(cmdArgs);

                Console.WriteLine(result);
            }
        }
    }
}
