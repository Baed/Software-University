using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.WeakStudents
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
                .Where(s => 
                    s.Skip(2)
                    .Select(int.Parse)
                    .Count(g => g <= 3)
                >= 2)
                .Select(s => s[0] + " " + s[1]);

            Console.WriteLine(string.Join("\r\n", result));
        }
    }
}
