using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');
            double[] fuelTanks = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            long[] zones = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            foreach (var name in names)
            {
                double fuelCount = 0;
                char firstLetterOfName = name[0];          // name[0].ToCharArray();
                int fuelStartValue = firstLetterOfName;    // firstLetterOfName.[0];

                int zoneCounter = 0;
                bool isReached = true;

                fuelCount += fuelStartValue;

                for (int i = 0; i < fuelTanks.Length; i++)
                {
                    foreach (var zone in zones)
                    {
                        if (i == zone)
                        {
                            fuelCount += fuelTanks[i] * 2;
                            break;
                        }
                    }

                    fuelCount -= fuelTanks[i];

                    if (fuelCount <= 0)
                    {
                        isReached = false;
                        break;
                    }

                    zoneCounter++;
                }
                if (isReached)
                {
                    Console.WriteLine("{0} - fuel left {1:f2}", name, fuelCount);
                }
                else
                {
                    Console.WriteLine("{0} - reached {1}", name, zoneCounter);
                }

            }

        }
    }
}
