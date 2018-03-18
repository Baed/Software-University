using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Client.Contracts;

namespace Employees.Client.Commands
{
    public class ExitCommand : ICommand
    {
        public string Execute(params string[] data)
        {
            Console.WriteLine("Goodbye!");

            Environment.Exit(0);

            return string.Empty;
        }
    }
}
