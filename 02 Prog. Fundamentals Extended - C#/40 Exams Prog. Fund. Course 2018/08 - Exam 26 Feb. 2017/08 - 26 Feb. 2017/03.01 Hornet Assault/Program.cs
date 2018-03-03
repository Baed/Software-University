using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._01_Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Length; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }

                long bees = beehives[i];

                long hornetPower = 0;

                foreach (var hornet in hornets)
                {
                    hornetPower += hornet;
                }

                beehives[i] -= hornetPower;

                if (bees >= hornetPower)
                {
                    hornets.RemoveAt(0);
                }
            }

            if (beehives.Any(bh => bh > 0))
            {
                Console.WriteLine(string.Join(" ", beehives.Where(bh => bh > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
