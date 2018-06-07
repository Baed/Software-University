using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Client.Contracts;
using Employees.DtoModels;
using Employees.Services;

namespace Employees.Client.Commands
{
    public class AddEmployeeCommand : ICommand
    {
        private readonly EmployeeService employeeService;

        public AddEmployeeCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        //<firstName> <lastName> <salary> 
        public string Execute(params string[] data)
        {
            string firstName = data[0];
            string lastName = data[1];
            decimal salary = decimal.Parse(data[2]);

            var employeeDto = new EmployeeDto(firstName, lastName, salary);

            this.employeeService.AddEmployee(employeeDto);

            return $"Employee {firstName} {lastName} is successfully added!";
        }   
    }
}
