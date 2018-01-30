using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double side_triangle = double.Parse(Console.ReadLine());
            double H_triangle = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double work_price = double.Parse(Console.ReadLine());

            var area_room = width * lenght;
            var tiles_аrea = side_triangle * H_triangle / 2;
            var needed_tiles = Math. Ceiling(area_room / tiles_аrea) + 5;
            var sum = needed_tiles * price + work_price;

            if (money >= sum)
            {
                Console.WriteLine($"{(money - sum):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {(sum - money):f2} lv more.");
            }
        }
    }
}
