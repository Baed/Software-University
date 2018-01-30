using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Filter_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> agesOfEmployee = new Dictionary<string, int>();
            Dictionary<string, double> salariesOfEmployee = new Dictionary<string, double>();
            Dictionary<string, string> positionsOfEmployee = new Dictionary<string, string>();

            string[] tokens = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (tokens[0] != "filter")
            {
                string name = tokens[0];
                string value = tokens[1]; // int, double, string ...

                int age;
                double salary;

                if (int.TryParse(tokens[1], out age))
                {
                    agesOfEmployee[name] = age;
                }
                else if (double.TryParse(tokens[1], out salary))
                {
                    salariesOfEmployee[name] = salary;
                }
                else
                {
                    positionsOfEmployee[name] = value;
                }

                tokens = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            string condition = Console.ReadLine().ToLower();

            if (condition == "position")
            {
                foreach (var employee in positionsOfEmployee)
                {
                    Console.WriteLine($"Name: {employee.Key}");
                    Console.WriteLine($"Position: {employee.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (condition == "age")
            {
                foreach (var employee in agesOfEmployee)
                {
                    Console.WriteLine($"Name: {employee.Key}");
                    Console.WriteLine($"Age: {employee.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else
            {
                foreach (var employee in salariesOfEmployee)
                {
                    Console.WriteLine($"Name: {employee.Key}");
                    Console.WriteLine($"Salary: {employee.Value:f2}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}
