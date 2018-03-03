using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine());

            decimal totalRainCoefficient = 0M;

            for (int i = 0; i < n; i++)
            {
                string[] regionParameters = Console.ReadLine().Split();

                long raindropsCount = long.Parse(regionParameters[0]);
                int squareMeters = int.Parse(regionParameters[1]);

                totalRainCoefficient += (raindropsCount / (decimal)squareMeters);
            }

            if (density != 0)
            {
                totalRainCoefficient = totalRainCoefficient / density;
            }

            Console.WriteLine($"{totalRainCoefficient:F3}");
        }
    }
}
