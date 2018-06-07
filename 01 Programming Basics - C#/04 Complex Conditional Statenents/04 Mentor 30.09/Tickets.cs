using System;
using System.Collections.Generic;

namespace Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string tickets = Console.ReadLine();
            decimal people = decimal.Parse(Console.ReadLine());

            if (people >= 50)
                budget -= (budget * 0.25m);
            else if (people >= 25)
                budget -= (budget * 0.40m);
            else if (people >= 10)
                budget -= (budget * 0.50m);
            else if (people >= 5)
                budget -= (budget * 0.60m);
            else if (people > 0)
                budget -= (budget * 0.75m);


            decimal moneyForTicket = 0m;

            if (tickets == "VIP")
                moneyForTicket = 499.99m * people;
            else if (tickets == "Normal")
                moneyForTicket = 249.99m * people;

            decimal diff = budget - moneyForTicket;

            if (diff >= 0)
                Console.WriteLine
                    ($"Yes! You have {diff:f2} leva left.");
            else
                Console.WriteLine
                    ($"Not enough money! You need {Math.Abs(diff):f2} leva.");
        }
    }
}
