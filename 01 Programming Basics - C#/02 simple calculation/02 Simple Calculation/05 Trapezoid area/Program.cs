using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Trapezoid_area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate trapezoid area");
            Console.Write("Enter parameter 'a': ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Enter parameter 'b': ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("Enter parameter 'h': ");
            var h = double.Parse(Console.ReadLine());
            var area = (a + b) * h / 2;

            // Console.WriteLine("The area is: {0} meter", area); // primer

            Console.WriteLine($"The result is:{area} meter");
        }
    }
}
