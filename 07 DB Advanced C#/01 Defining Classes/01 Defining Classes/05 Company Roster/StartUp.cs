using System.Xml.Linq;

namespace _05_Company_Roster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Employee>> departmentsData = Reader();

            ExecudeProgram(departmentsData);
        }

        private static void ExecudeProgram(Dictionary<string, List<Employee>> departmentsData)
        {
            decimal highestAvgSalary = 0;
            string departmentByHighestSalary = string.Empty;

            foreach (var deprtment in departmentsData)
            {
                decimal currentSalary = 0;

                foreach (var employee in deprtment.Value)
                {
                    currentSalary += employee.Salary;

                }

                decimal averageSalary = currentSalary / deprtment.Value.Count;

                if (averageSalary > highestAvgSalary)
                {
                    highestAvgSalary = averageSalary;
                    departmentByHighestSalary = deprtment.Key;
                }               
            }

            Console.WriteLine($"Highest Average Salary: {departmentByHighestSalary}");

            foreach (var employee in departmentsData[departmentByHighestSalary].OrderByDescending(e => e.Salary))
            {
                Console.WriteLine(employee);
            }
        }

        private static Dictionary<string, List<Employee>> Reader()
        {
            Dictionary<string, List<Employee>> departmentsData = new Dictionary<string, List<Employee>>();

            int n = int.Parse(Console.ReadLine());
            while (n-- > 0)
            {
                var commands = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = commands[0];
                decimal salary = decimal.Parse(commands[1]);
                string position = commands[2];
                string department = commands[3];

                Employee employee = new Employee(name, salary, position, department);

                if (commands.Length == 5)
                {
                    var isAge = int.TryParse(commands[4], out int age);
                    if (isAge)
                    {
                        employee.Age = age;
                    }
                    else
                    {
                        employee.Email = commands[4];
                    }
                }

                else if (commands.Length == 6)
                {
                    employee.Email = commands[4];
                    employee.Age = int.Parse(commands[5]);
                }

                if (!departmentsData.ContainsKey(department))
                {
                    departmentsData.Add(department, new List<Employee>());
                }

                departmentsData[department].Add(employee);
            }

            return departmentsData;
        }
    }
}
