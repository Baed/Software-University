namespace E03___05_BarracksWars.Core
{
    using Attributes;
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;

    public class CommandInterpreter : ICommandInterpreter
    {
        private const string CommandSuffix = "Command";

        private IRepository repository;
        private IUnitFactory unitFactory;

        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            string commandCompleteName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(commandName) + CommandSuffix; //first letter in word to upcase

            Type commandType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == commandCompleteName);

            object[] commandParams =
            {  
                // task 4
                // data,
                // this.repository,
                // this.unitFactory
                data
            };

            if (commandType == null)
            {
                throw new InvalidOperationException("Invalid command!");
            }

            // return (IExecutable)Activator.CreateInstance(commandType, commandParams); task 4
            IExecutable currentCommand = (IExecutable)Activator.CreateInstance(commandType, commandParams);

            //inject
            currentCommand = this.InjectDependencies(currentCommand);

            return currentCommand;
        }

        private IExecutable InjectDependencies(IExecutable currentCommand)
        {
            FieldInfo[] commandFields = currentCommand
                .GetType()
                .GetFields(
                        BindingFlags.Instance |
                        BindingFlags.NonPublic)
                .Where(f => f.GetCustomAttribute<InjectAttribute>() != null)
                .ToArray();

            FieldInfo[] interpreterFields = this.GetType()
                .GetFields(
                         BindingFlags.Instance |
                         BindingFlags.NonPublic);

            foreach (FieldInfo commandfield in commandFields)
            {
                commandfield
                    .SetValue(
                            currentCommand, 
                            interpreterFields.First(f => f.FieldType == commandfield.FieldType)
                    .GetValue(this));
            }

            return currentCommand;
        }
    }
}
