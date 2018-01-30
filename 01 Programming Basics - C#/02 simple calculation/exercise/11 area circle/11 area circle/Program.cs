using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_area_circle
{
    class Program
    {
        static void Main(string[] args)
        {

            double r = double.Parse(Console.ReadLine());
            double perimeter = Math.PI * 2 * r;
            double area = Math.PI * r * r;

            // double r = double.Parse(Console.ReadLine());
            // double area = Math.PI * r * r; 
            // Console.WriteLine(Math.PI * r * r); втори начин
            // Console.WriteLine(area);

            // zakruglqne

            // double roundedArea = Math.Round(area, 2);
            // double roundedPerimeter = Math.Round(perimeter, 2);

            // Console.WriteLine(perimeter);
            // Console.WriteLine(roundedPerimeter);
            // Console.WriteLine(area);
            // Console.WriteLine(roundedArea);

            // sykraten variant ($"Math.Round{}"

            // Console.WriteLine($"{Math.Round(perimeter, 2)}");
            // Console.WriteLine($"{Math.Round(area, 2)}");

            // oshte po sukraten variant ($"{:}"

            Console.WriteLine($"{perimeter:f2}");
            Console.WriteLine($"{area:f2}");
        }
    }
}
