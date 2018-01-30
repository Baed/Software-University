using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Circle_area_and_perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cirle area and perimeter");
            Console.Write("Enter parameter 'r': ");
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            var perimeter = Math.PI*r*2;
            Console.Write("The area is: ");
            Console.WriteLine($"{area:f2}");
            Console.Write("The perimeter is: ");
            Console.WriteLine($"{perimeter:f2}");
            
            // Console.WriteLine($"{Math.Round(perimeter, 2)}");
            // Console.WriteLine($"{Math.Round(area, 2)}");
        }
    }
}
