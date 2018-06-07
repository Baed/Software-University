using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_2D_rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2d rectangle area");
            Console.Write("Enter parameter 'x1': ");
            var x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter parameter 'y1': ");
            var y1 = double.Parse(Console.ReadLine());
            Console.Write("Enter parameter 'x2': ");
            var x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter parameter 'y2': ");
            var y2 = double.Parse(Console.ReadLine());
            var a = Math.Abs(x1 - x2);
            var b = Math.Abs(y1 - y2);
            var area = a * b;
            var perimeter = (a + b) * 2;
            Console.Write("The area is: ");
            Console.WriteLine($"{area:f2}");
            Console.Write("The perimeter is: ");
            Console.WriteLine($"{perimeter:f2}");
        }
    }
}
