using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Students_Enrolled_in_2014_or_2015
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

            studentsbook
                .Where(arr => arr[0].EndsWith("14") || arr[0].EndsWith("15"))
                .Select(arr => arr.Skip(1)) // .Select(arr => arr[1])
                .ToList()
                .ForEach(arr => Console.WriteLine(string.Join(" ", arr)));
        }
    }
}
