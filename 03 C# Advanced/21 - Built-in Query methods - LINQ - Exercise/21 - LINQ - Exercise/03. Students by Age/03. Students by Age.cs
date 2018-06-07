using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Students_by_Age
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
                .Where(s => 18 <= int.Parse(s[2]) && int.Parse(s[2]) <= 24 )                
                .Select(s => string.Join(" ", s));

            Console.WriteLine(string.Join("\r\n", result));
        }
    }
}
