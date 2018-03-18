using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Client.Contracts;
using Employees.Services;

namespace Employees.Client.Commands
{
    public class SetManagerCommand : ICommand
    {
        private readonly EmployeeService empService;

        public SetManagerCommand(EmployeeService empService)
        {
            this.empService = empService;
        }
        // <employeeId> <managerId> 
        public string Execute(params string[] data)
        {
            var employeeId = int.Parse(data[0]);

            var managerId = int.Parse(data[1]);

            this.empService.SetEmployeeToManager(employeeId, managerId);

            return $"Employee with ID {employeeId}'s manager is now employee with ID {managerId}.";
        }
    }
}
