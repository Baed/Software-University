using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_lice_na_pravougulnik_v_ravninata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x1, y1, x2 and y2 to calculate area and perimeter to rectengular");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            //double a = Math.Max(x1, x2) - Math.Min(x1, x2);
            //double b = Math.Max(y1, y2) - Math.Min(y1, y2);

            double a = Math.Abs(x1 - x2);
            double b = Math.Abs(y1 - y2);
            double area = a * b;
            double perimeter = 2 * (a + b);

            Console.Write("result a: ");
            Console.WriteLine(a);
            Console.Write("result b: ");
            Console.WriteLine(b);

            Console.WriteLine("result area, perimeter :");
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
            
        }
    }
}
