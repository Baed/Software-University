using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Client.Contracts;
using Employees.Services;

namespace Employees.Client.Commands
{
    public class SetBirthdayCommand : ICommand
    {
        private readonly EmployeeService employeeService;

        public SetBirthdayCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        //<employeeId> <date: "dd-MM-yyyy"> 
        public string Execute(params string[] data)
        {
            int employeeId = int.Parse(data[0]);

            DateTime date = DateTime.ParseExact(data[1], "dd-MM-yyyy", null);

            var employeeName =  employeeService.SetBirthday(employeeId, date);

            return $"{employeeName}'s birthday was set to {data[1]}";
        }
    }
}