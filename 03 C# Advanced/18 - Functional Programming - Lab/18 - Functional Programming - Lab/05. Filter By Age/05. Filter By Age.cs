using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> personsData = GetPersons();

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string wantedFormat = Console.ReadLine();

            Func<int, bool> ageFilter = GetAgeFilter(condition, age);
            Action<KeyValuePair<string, int>> printer = PrinterFormat(wantedFormat);

            PrintResultByFilter(personsData, ageFilter, printer);
        }

        private static void PrintResultByFilter(Dictionary<string, int> dataPersons, Func<int, bool> ageFilter, Action<KeyValuePair<string, int>> printer)
        {
            foreach (var person in dataPersons)
            {
                if (ageFilter(person.Value))
                {
                    printer(person);
                }
            }
        }

        private static Action<KeyValuePair<string, int>> PrinterFormat(string wantedFormat)
        {
            switch (wantedFormat)
            {
                case "name age":
                    return p => Console.WriteLine($"{p.Key} - {p.Value}");
                case "name":
                    return p => Console.WriteLine($"{p.Key}");
                case "age":
                    return p => Console.WriteLine($"{p.Value}");
                default: return null;
            }
        }

        private static Func<int, bool> GetAgeFilter(string condition, int age)
        {
            switch (condition)
            {
                case "older": return x => x >= age;
                case "younger": return x => x < age;
                default: return null;
            }
        }

        private static Dictionary<string, int> GetPersons()
        {
            int n = int.Parse(Console.ReadLine());

            var data = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var name = tokens[0];
                var age = int.Parse(tokens[1]);

                //personsData.Add(name, age);
                data[name] = age;
            }
            return data;
        }
    }
}
