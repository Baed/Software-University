using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal .Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            var transport = 0.0m;
            var ticket = 0.0m;
            
            if (category == "VIP")
            {
                ticket = 499.99m;
            }
            else if (category == "Normal")
            {
                ticket = 249.99m;
            }

            if (people >= 1 && people <= 4)
            {
                transport = 0.75m;
            }
            else if (people >= 5 && people <= 9)
            {
                transport = 0.60m;
            }
            else if (people >= 10 && people <= 24)
            {
                transport = 0.50m;
            }
            else if (people >= 25 && people <= 49)
            {
                transport = 0.40m;
            }
            else if (people >= 50) // pochvame s tova. to e nai golqmo
            {
                transport = 0.25m;
            }

            decimal residue = (budget - budget * transport);
            decimal agitaTicket = people * ticket;

            if (residue >= agitaTicket)
            {
                Console.WriteLine($"Yes! You have {(residue - agitaTicket):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(agitaTicket - residue):f2} leva.");
            }
        }
    }
}
