using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Client.Contracts;
using Employees.Services;

namespace Employees.Client.Commands
{
    public class EmployeePersonalInfoCommand : ICommand
    {
        private readonly EmployeeService employeeService;

        public EmployeePersonalInfoCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        //<employeeId>
        public string Execute(params string[] data)
        {
            var id = int.Parse(data[0]);

            var employeeDto = employeeService.PeronalById(id);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"ID: {employeeDto.Id} - {employeeDto.FirstName} {employeeDto.LastName} - ${employeeDto.Salary:f2}");
            sb.AppendLine($"Birthday: {string.Format("dd-MM-yyyy", employeeDto.Birthday)}");
            sb.AppendLine($"Address: {employeeDto.Address}");

            string result = sb.ToString().Trim();

            return result;
        }
    }
}