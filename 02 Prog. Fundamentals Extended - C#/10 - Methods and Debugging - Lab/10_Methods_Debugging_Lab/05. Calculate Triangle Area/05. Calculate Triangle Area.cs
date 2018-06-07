using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = Area(width, height);
            Console.WriteLine(area);
        }
        static double Area(double n, double m) // (double width, double height)
        {
            return n * m / 2;    // return width * height / 2;
        }
    }
}
