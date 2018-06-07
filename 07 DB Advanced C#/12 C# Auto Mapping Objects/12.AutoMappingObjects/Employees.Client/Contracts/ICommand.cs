using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Client.Contracts
{
    public interface ICommand
    {
        string Execute(params string[] data);
    }
}
