using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Triangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle area");
            Console.Write("Enter parameter 'a': ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Enter parameter 'h': ");
            var h = double.Parse(Console.ReadLine());
            var area = a * h / 2;
            Console.Write("The area is: ");

            // Console.WriteLine($"{Math.Round(area, 2)}");

            Console.WriteLine($"{area:f2}");
        }
    }
}
