using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Filter_Students_by_Phone
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

            var prefixes = new [] { "02", "+3592" };

            var result = studentsbook
                .Where(s => prefixes.Any(p => s[2].StartsWith(p)))
                .Select(s => s[0] + " " + s[1]);

            Console.WriteLine(string.Join("\r\n", result));
        }
    }
    
}
