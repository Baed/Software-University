using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Employees.DtoModels;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Employees.Client.Contracts;
using Employees.Services;

namespace Employees.Client.Commands
{
    public class ListEmployeesOlderThanCommand : ICommand
    {
        private readonly EmployeeService empService;

        public ListEmployeesOlderThanCommand(EmployeeService empService)
        {
            this.empService = empService;
        }

        public string Execute(params string[] data)
        {
            var age = int.Parse(data[0]);

            var employees = this.empService.GetEmployeesOlderThan(age);

            if (employees.Count == 0)
            {
                return "No such employees found.";
            }

            var sb = new StringBuilder();

            foreach (var employeeDto in employees)
            {
                var managerName = "[no manager]";

                if (employeeDto.Employee.Manager != null) // employeeDto.Manager
                {
                    managerName = employeeDto.Employee.Manager.LastName; // employeeDto.Manager.LastName
                }

                sb.AppendLine($"{employeeDto.FirstName} {employeeDto.LastName} - ${employeeDto.Salary:F2} - Manager: {managerName}");
            }

            return sb.ToString().Trim();
        }
    }
}