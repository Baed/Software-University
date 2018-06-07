using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            var average = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse);

            Console.WriteLine($"{average.Average():f2}");
        }
    }
}
