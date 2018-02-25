using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Startup
{
    public static void Main()
    {
        List<Department> departments = Reader();

        Writer(departments);
    }

    private static void Writer(List<Department> departments)
    {
        var currentDepartment = departments
            .OrderByDescending(d => d.Employees.Average(e => e.Salary))
            .FirstOrDefault();

        Console.WriteLine($"Highest Average Salary: {currentDepartment.Name}");

        foreach (var employee in currentDepartment.Employees.OrderByDescending(e => e.Salary))
        {
            Console.WriteLine(employee);
        }
    }

    private static List<Department> Reader()
    {
        List<Department> departmentsList = new List<Department>();

        var n = int.Parse(Console.ReadLine());
        while (n-- > 0)
        {
            var cmdArgs = Console.ReadLine().Split();

            var name = cmdArgs[0];
            var salary = decimal.Parse(cmdArgs[1]);
            var possition = cmdArgs[2];
            var departmentName = cmdArgs[3];

            if (!departmentsList.Any(d => d.Name == departmentName))
            {
                Department department = new Department(departmentName);

                departmentsList.Add(department);
            }

            if (!departmentsList.Any(d => d.Employees.Any(e => e.Name == name)))
            {
                var employee = new Employee(name, possition, departmentName, salary);

                if (cmdArgs.Length == 6)
                {
                    employee.Email = cmdArgs[4];
                    employee.Age = int.Parse(cmdArgs[5]);
                }
                else if (cmdArgs.Length == 5)
                {
                    if (cmdArgs[4].Contains("@"))
                    {
                        employee.Email = cmdArgs[4];
                    }
                    else
                    {
                        employee.Age = int.Parse(cmdArgs[4]);
                    }
                }

                departmentsList.FirstOrDefault(d => d.Name == departmentName).Employees.Add(employee);
            }
        }

        return departmentsList;
    }
}
