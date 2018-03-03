using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split().ToList();
            List<decimal> zones = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            List<int> checkpointIndex = Console.ReadLine().Split().Select(int.Parse).ToList();

            foreach (string name in participants)
            {
                decimal sum = 0;
                char firstLetter = name[0];
                int firstInteger = firstLetter;

                int zone = 0;
                bool isReached = true;

                sum += firstInteger;

                for (int i = 0; i < zones.Count; i++)
                {
                    foreach (int position in checkpointIndex)
                    {
                        if (i == position)
                        {
                            sum += zones[i] * 2;
                            break;
                        }
                    }
                    sum -= zones[i];

                    if (sum <= 0)
                    {
                        isReached = false;
                        break;
                    }
                    zone++;
                }
                if (isReached)
                {
                    Console.WriteLine("{0} - fuel left {1:f2}", name, sum);
                }
                else
                {
                    Console.WriteLine("{0} - reached {1}", name, zone);
                }
            }
        }
    }
}
