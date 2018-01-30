using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int PeshoStrike = int.Parse(Console.ReadLine());
            int GoshoStrike = int.Parse(Console.ReadLine());

            var roundctr = 1;
            var GoshoHealth = 100;
            var PeshoHealth = 100;
            while (true) // (PeshoHealth > 0 && GoshoHealth > 0)
            {
                if (roundctr % 2 != 0)
                {
                    GoshoHealth -= PeshoStrike;
                    if (GoshoHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {GoshoHealth} health.");
                }
                else
                {
                    PeshoHealth -= GoshoStrike;
                    if (PeshoHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {PeshoHealth} health.");
                }
                if (roundctr % 3 == 0)
                {
                        GoshoHealth += 10;
                        PeshoHealth += 10;
                }
                roundctr++;
            }
            if (PeshoHealth > GoshoHealth)
            {
                Console.WriteLine($"Pesho won in {roundctr}th round.");
            }
            else
            {
                Console.WriteLine($"Gosho won in {roundctr}th round.");
            }
        }
    }
}




