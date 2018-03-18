using System;
using System.Linq;
using System.Reflection;
using Employees.Client.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Employees.Client
{
    public class CommandParser
    {
        public static ICommand Parse(IServiceProvider serviceProvider, string commandName)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var commandTypes = assembly
                .GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(ICommand)))
                .ToArray();

            var commandType = commandTypes
                .SingleOrDefault(t => t.Name.ToLower() == $"{commandName.ToLower()}command");

            if (commandType == null)
            {
                throw new InvalidOperationException("Invalid command type!");
            }

            var constructor = commandType
                .GetConstructors()
                .First();

            if (constructor == null)
            {
                throw new InvalidOperationException("Invalid constructor!");
            }

            var constructorParameters = constructor
                .GetParameters()
                .Select(p => p.ParameterType)
                .ToArray();

            var services = constructorParameters
                .Select(serviceProvider.GetService)
                .ToArray();

            var command = (ICommand)constructor.Invoke(services);

            return command;
        }
    }
}
