using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());
            var pricePerKm = 0.0;

            if (kmPerMonth > 10000 && kmPerMonth <= 20000)
            {
                if (season == "Spring" || season == "Autumn" || season == "Summer" || season == "Winter")
                {
                    pricePerKm = 1.45;
                }
            }
            else if (kmPerMonth > 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    pricePerKm = 0.95;
                }
                else if (season == "Summer")
                {
                    pricePerKm = 1.10;
                }
                else if (season == "Winter")
                {
                    pricePerKm = 1.25;
                }
            }
            else if (kmPerMonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    pricePerKm = 0.75;
                }
                else if (season == "Summer")
                {
                    pricePerKm = 0.90;
                }
                else if (season == "Winter")
                {
                    pricePerKm = 1.05;
                }
            }

            Console.WriteLine($"{kmPerMonth*pricePerKm*4*0.90:f2}");
        }
    }
}
