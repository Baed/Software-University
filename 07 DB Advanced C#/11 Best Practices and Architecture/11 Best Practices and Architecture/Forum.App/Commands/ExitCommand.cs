using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.App.Commands.Contracts;

namespace Forum.App.Commands
{
    public class ExitCommand : ICommand
    {
        public string Execude(params string[] arguments)
        {
            Environment.Exit(0);

            return string.Empty;
        }
    }
}
