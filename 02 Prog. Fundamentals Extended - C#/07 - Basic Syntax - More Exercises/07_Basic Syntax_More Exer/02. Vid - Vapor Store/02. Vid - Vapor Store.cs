using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vid___Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {          
            double OutFall4Price = 39.99;
            double CSOGPrice = 15.99;
            double ZplinterZellPrice = 19.99;
            double Honored2Price = 59.99;
            double RoverWatchPrice = 29.99;
            double RoverWatchOriginsEditionPrice = 39.99;

            double budget = double.Parse(Console.ReadLine());
            double price = 0;
            var startingPrice = budget;

            string input = Console.ReadLine();

            while (input != "Game Time")
            {
               
                if (input == "OutFall 4")
                {
                    price = OutFall4Price;
                }
                else if (input == "CS: OG")
                {
                    price = CSOGPrice;
                }
                else if (input == "Zplinter Zell")
                {
                    price = ZplinterZellPrice;
                }
                else if (input == "Honored 2")
                {
                    price = Honored2Price;
                }
                else if (input == "RoverWatch")
                {
                    price = RoverWatchPrice;
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    price = RoverWatchOriginsEditionPrice;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    input = Console.ReadLine();
                    continue;
                }
                if (price <= budget)
                {
                    Console.WriteLine($"Bought {input}");
                    budget -= price;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
                if (budget <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                input = Console.ReadLine();
            }
                Console.WriteLine($"Total spent: ${startingPrice - budget:f2}. Remaining: ${budget:f2}");
        }
    }
}
