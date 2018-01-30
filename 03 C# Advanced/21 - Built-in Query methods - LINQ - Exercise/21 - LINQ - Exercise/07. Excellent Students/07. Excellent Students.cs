using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Excellent_Students
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
                .Where(s => s.Any(g => g == "6"))
               // .Where(s => s.Skip(2).Any(g => g == "6")) skip 0 and 1 tokens
                .Select(s => s[0] + " " + s[1]);

            Console.WriteLine(string.Join("\r\n", result));
        }
    }
}
