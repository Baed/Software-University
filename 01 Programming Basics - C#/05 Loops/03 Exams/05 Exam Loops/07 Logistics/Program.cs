using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int load = int.Parse(Console.ReadLine());

            var bus = 0.0;
            var truck = 0.0;
            var train = 0.0;
            var allTransport = 0.0;

            for (int i = 1; i <= load; i++)
            {
                int weight = int.Parse(Console.ReadLine());

                allTransport += weight;

                if (weight >= 12)
                {
                    train += weight;
                }
                else if (weight >= 4)
                {
                    truck += weight;
                }
                else
                {
                    bus += weight;
                }
            }

            double average = (bus * 200 + truck * 175 + train * 120) / allTransport;

            Console.WriteLine($"{average:f2}");
            Console.WriteLine($"{(100 * bus / allTransport):f2}%");
            Console.WriteLine($"{(100 * truck / allTransport):f2}%");
            Console.WriteLine($"{(100 * train / allTransport):f2}%");

        }
    }
}
