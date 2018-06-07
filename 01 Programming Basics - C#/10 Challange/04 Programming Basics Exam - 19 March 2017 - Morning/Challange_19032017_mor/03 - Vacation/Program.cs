using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            var accommodation = "";
            var location = "";
            var price = 0.0;

            if (budget > 3000)
            {
                accommodation = "Hotel";
                price = 0.90;
                if (season == "Summer")
                {
                    location = "Alaska";
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                }
            }
            else if (budget > 1000)
            {
                accommodation = "Hut";
                if (season == "Summer")
                {
                    price = 0.80;
                    location = "Alaska";
                }
                else if (season == "Winter")
                {
                    price = 0.60;
                    location = "Morocco";
                }
            }
            else
            {
                accommodation = "Camp";
                if (season == "Summer")
                {
                    price = 0.65;
                    location = "Alaska";
                }
                else if (season == "Winter")
                {
                    price = 0.45;
                    location = "Morocco";
                }
            }

            Console.WriteLine($"{location} - {accommodation} - {(budget * price):f2}");
        }
    }
}

