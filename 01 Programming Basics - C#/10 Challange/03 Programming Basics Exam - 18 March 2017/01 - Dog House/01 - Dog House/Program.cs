using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Dog_House
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenghtSide_A = double.Parse(Console.ReadLine());
            double hightHouse_B = double.Parse(Console.ReadLine());

            double area_side = 2 * (lenghtSide_A * lenghtSide_A / 2);
            double area_backside = (lenghtSide_A/2*lenghtSide_A/2) + (lenghtSide_A / 2 * (hightHouse_B - lenghtSide_A / 2) / 2);
            double front_area = area_backside - lenghtSide_A / 5 * lenghtSide_A/5;
            double roof_area = 2 * (lenghtSide_A * lenghtSide_A / 2);

            double area_walls  = area_side + area_backside + front_area;

            Console.WriteLine($"{area_walls / 3:f2}");
            Console.WriteLine($"{roof_area / 5:f2}");

        }
    }
}
