using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double area_house = double.Parse(Console.ReadLine());
            int windows = int.Parse(Console.ReadLine());
            double styrofoam_square = double.Parse(Console.ReadLine());
            double price_styrofoam = double.Parse(Console.ReadLine());

            var calc = Math.Ceiling((area_house - windows * 2.4) * 1.1 / styrofoam_square) * price_styrofoam;

            if (budget > calc)
            {
                Console.WriteLine($"Spent: {calc:f2}\nLeft: {budget - calc:f2}");
            }
            else
            {
                Console.WriteLine($"Need more: {calc - budget:f2}");
            }
        }
    }
}
