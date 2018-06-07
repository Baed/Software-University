using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());

            var price_studio = 0.0;
            var price_double = 0.0;
            var price_suite = 0.0;

            if (month == "may" || month == "october")
            {
                price_studio = 50 * nights;
                price_double = 65 * nights;
                price_suite = 75 * nights;
                if (nights > 7 && month == "october")
                {
                    price_studio = (50 * (nights - 1));
                }
                if (nights > 7)
                {
                    price_studio *= 0.95;
                }
            }
            else if (month == "june" || month == "september")
            {
                price_studio = 60 * nights;
                price_double = 72 * nights;
                price_suite = 82 * nights;

                if (nights > 7 && month == "september")
                {
                    price_studio = (60 * (nights - 1));
                }
                if (nights > 14)
                {
                    price_double *= 0.90;
                }
            }
            else if (month == "july" || month == "august" || month == "december")
            {
                price_studio = 68 * nights;
                price_double = 77 * nights;
                price_suite = 89 * nights;
                if (nights > 14)
                {
                    price_suite *= 0.85;
                }
            }
            Console.WriteLine($"Studio: {price_studio:f2} lv.");
            Console.WriteLine($"Double: {price_double:f2} lv.");
            Console.WriteLine($"Suite: {price_suite:f2} lv.");
        }
    }
}
