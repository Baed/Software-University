using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Client.Contracts;
using Employees.Services;

namespace Employees.Client.Commands
{
    public class SetAddressCommand : ICommand
    {
        private readonly EmployeeService employeeService;

        public SetAddressCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        //<employeeId> <address> 
        public string Execute(params string[] data)
        {
            int employeeId = int.Parse(data[0]);

            string address = string.Join(" ", data.Skip(1));

            var employeeName = employeeService.SetAddress(employeeId, address);

            return $"{employeeName}'s adress was set to {address}";
        }
    }
}
