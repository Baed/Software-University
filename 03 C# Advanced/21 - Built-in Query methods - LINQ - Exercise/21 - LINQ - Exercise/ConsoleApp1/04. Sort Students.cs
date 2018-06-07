using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var studentsbook = new List<string[]>();

            while (input != "END")
            {
                var tokens = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                studentsbook.Add(tokens);

                input = Console.ReadLine();
            }

            var result = studentsbook
                .OrderBy(s => s[1])
                .ThenByDescending(s => s[0])
                .Select(s => string.Join(" ", s));

            Console.WriteLine(string.Join("\r\n", result));
        }
    }
}
