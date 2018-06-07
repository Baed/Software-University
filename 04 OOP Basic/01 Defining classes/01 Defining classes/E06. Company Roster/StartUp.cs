using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main(string[] args)
    {
        var numberOfEmployee = int.Parse(Console.ReadLine());
        var employeesList = new List<Employee>();

        for (int i = 0; i < numberOfEmployee; i++)
        {
            var employeeInfo = Console.ReadLine().Split(' ');

            var employee = new Employee
                  (
                  employeeInfo[0],
                  decimal.Parse(employeeInfo[1]),
                  employeeInfo[2],
                  employeeInfo[3]
                  );

            if (employeeInfo.Length > 4)
            {
                if (int.TryParse(employeeInfo[4], out int age))
                {
                    employee.Age = age;
                }
                else
                {
                    employee.Email = employeeInfo[4];
                }

            }
            if (employeeInfo.Length > 5)
            {
                employee.Age = int.Parse(employeeInfo[5]);
            }

            employeesList.Add(employee);
        }

        var result = employeesList
            .GroupBy(emp => emp.Department)
            .Select(gr => new
            {
                Name = gr.Key,
                AverageSalary = gr.Average(emp => emp.Salary),
                Employees = gr
            })
            .OrderByDescending(gr => gr.AverageSalary)
            .FirstOrDefault();

        Console.WriteLine($"Highest Average Salary: {result.Name}");

        foreach (var emp in result.Employees.OrderByDescending(em => em.Salary))
        {
            Console.WriteLine(emp.ToString());
        }
    }
}
