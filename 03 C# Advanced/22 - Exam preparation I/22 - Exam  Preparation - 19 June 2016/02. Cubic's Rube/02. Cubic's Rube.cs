using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cubic_s_Rube
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensionSize = int.Parse(Console.ReadLine());

            var sumOfParticles = 0L;
            var changedCells = 0;

            string input;
            while ((input = Console.ReadLine()) != "Analyze")
            {
                var tokens = input
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                if (tokens.Take(3).Any(pt => 0 > pt || pt >= dimensionSize)) // out of borders
                {
                    continue;
                }

                if (tokens[3] != 0)
                {
                    sumOfParticles += tokens[3];
                    changedCells++;
                }
            }

            Console.WriteLine(sumOfParticles);
            Console.WriteLine(Math.Pow(dimensionSize, 3) - changedCells);
        }
    }
}
