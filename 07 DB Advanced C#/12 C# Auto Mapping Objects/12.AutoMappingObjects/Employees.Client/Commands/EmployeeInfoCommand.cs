using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Client.Contracts;
using Employees.Services;

namespace Employees.Client.Commands
{
    public class EmployeeInfoCommand : ICommand
    {
        private readonly EmployeeService employeeService;

        public EmployeeInfoCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        // <employeeId> 
        public string Execute(params string[] data)
        {
            int employeeId = int.Parse(data[0]);

            var employeeDto = employeeService.ById(employeeId);

            return $"ID: {employeeId} - {employeeDto.FirstName} {employeeDto.LastName} - ${employeeDto.Salary:f2}";
        }
    }
}