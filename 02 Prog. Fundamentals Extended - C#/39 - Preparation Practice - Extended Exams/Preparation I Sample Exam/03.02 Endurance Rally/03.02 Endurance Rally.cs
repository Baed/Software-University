using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._02_Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            decimal[] fuelTanks = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            int[] zones = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rounds = names.Length;
            int letterIdentifier = 0;

            while (rounds > 0)
            {
                bool isReached = false;
                char[] toFindTheFirstLetter = names[letterIdentifier].ToCharArray();

                decimal fuelStartValue = toFindTheFirstLetter[0];

                for (int i = 0; i < fuelTanks.Length; i++)
                {
                    if (fuelStartValue > 0)
                    {
                        if (zones.Contains(i))
                        {
                            fuelStartValue += fuelTanks[i];
                        }
                        else
                        {
                            fuelStartValue -= fuelTanks[i];
                        }
                    }
                    if (fuelStartValue <= 0)
                    {
                        Console.WriteLine($"{names[letterIdentifier]} - reached {i}");
                        isReached = true;
                        break;
                    }
                }

                if (isReached == false)
                {
                    Console.WriteLine($"{names[letterIdentifier]} - fuel left {fuelStartValue:f2}");
                }

                rounds--;
                letterIdentifier++;
            }
        }
    }
}
