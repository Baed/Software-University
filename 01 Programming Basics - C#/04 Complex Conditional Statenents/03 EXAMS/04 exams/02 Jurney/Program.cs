using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Jurney
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();


            var pocket = 0.0;

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");

                if (season == "summer")
                {
                    pocket = budget * 0.3;
                    Console.WriteLine($"Camp - {pocket:f2}");
                }

                else if (season == "winter")
                {
                    pocket = budget * 0.7;
                    Console.WriteLine($"Hotel - {pocket:f2}");
                }
            }

            else if (budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    pocket = budget * 0.4;
                    Console.WriteLine($"Camp - {pocket:f2}");
                }

                else if (season == "winter")
                {
                    pocket = budget * 0.8;
                    Console.WriteLine($"Hotel - {pocket:f2}");
                }
            }

            else if (budget > 1000 && (season == "summer" || season == "winter"))
            {
               
                 Console.WriteLine("Somewhere in Europe");
                 pocket = budget * 0.9;
                 Console.WriteLine($"Hotel - {pocket:f2}");
                
            }
        }
    }
}
