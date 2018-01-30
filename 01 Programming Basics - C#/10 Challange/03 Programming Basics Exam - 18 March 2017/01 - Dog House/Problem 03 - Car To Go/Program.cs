using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03___Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string car_class = "";
            string car_type = "";
            double price = 0.0;

            if (budget > 500 && (season == "Summer" || season == "Winter"))
            {
                car_class = "Luxury class";
                car_type = "Jeep";
                price = budget * 0.90;
            }
            else if (budget > 100)
            {
                car_class = "Compact class";
                if (season == "Summer")
                {
                    car_type = "Cabrio";
                    price = budget * 0.45;
                }
                else if (season == "Winter")
                {
                    car_type = "Jeep";
                    price = budget * 0.80;
                }
            }

            else if (budget <= 100 && budget > 0)
            {
                car_class = "Economy class";
                if (season == "Summer")
                {
                    car_type = "Cabrio";
                    price = budget * 0.35;
                }
                else if (season == "Winter")
                {
                    car_type = "Jeep";
                    price = budget * 0.65;
                }
            }

            Console.WriteLine(car_class);
            Console.WriteLine($"{car_type} - {price:f2}");
            
        }
    }
}
