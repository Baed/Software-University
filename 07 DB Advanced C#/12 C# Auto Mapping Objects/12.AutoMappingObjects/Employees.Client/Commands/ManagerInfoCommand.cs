using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Client.Contracts;
using Employees.Services;

namespace Employees.Client.Commands
{
    public class ManagerInfoCommand : ICommand
    {
        private readonly EmployeeService empService;

        public ManagerInfoCommand(EmployeeService empService)
        {
            this.empService = empService;
        }
        // <employeeId> 
        public string Execute(params string[] data)
        {
            var employeeId = int.Parse(data[0]);

            return this.empService.GetManagerInfo(employeeId);
        }
    }
}