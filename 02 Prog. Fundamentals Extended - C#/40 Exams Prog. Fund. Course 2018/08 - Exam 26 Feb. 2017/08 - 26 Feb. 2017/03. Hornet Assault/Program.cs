using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] beehives = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            long[] hornets = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            long hornetPower = hornets.Sum();
            int currentHornets = 0;

            for (int i = 0; i < beehives.Length; i++)
            {
                long bees = beehives[i];

                if (bees >= hornetPower)
                {
                    beehives[i] -= hornetPower;

                    if (currentHornets < hornets.Length)
                    {
                        hornetPower -= hornets[currentHornets];
                        currentHornets++;
                    }
                }
                else
                {
                    beehives[i] -= hornetPower;
                }
            }

            if (beehives.Any(b => b > 0))
            {
                List<long> result = beehives.Where(b => b > 0).ToList();
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                var result = hornets.Skip(currentHornets).ToArray();
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
