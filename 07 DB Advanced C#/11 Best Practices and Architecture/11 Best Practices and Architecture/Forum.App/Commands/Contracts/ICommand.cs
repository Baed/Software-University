using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.App.Commands.Contracts
{
    public interface ICommand
    {
        string Execude(params string[] arguments);
    }
}
