using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.House_Price
{
    class Program
    {
        static void Main(string[] args)
        {

            double min_room = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double price_sq_m = double.Parse(Console.ReadLine());

            double bathroom = min_room / 2;
            double room_2 = min_room * 1.10;
            double room_3 = room_2 * 1.10;
            var area = min_room + kitchen + bathroom + room_2 + room_3;
            var corridor = area * 0.05;
            var full_area = area + corridor;
            Console.WriteLine($"{full_area* price_sq_m:f2}");
        }
    }
}
