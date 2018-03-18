using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Models;

namespace Employees.DtoModels
{
    public class EmployeeDto
    {
        public EmployeeDto()
        {
            // for mapper
        }

        public EmployeeDto(string firstName, string lastName, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Salary { get; set; }

        public Employee Employee { get; set; }
    }
}
