using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Harvest
{
    class Program
    {
        static void Main(string[] args)
        {

            int X = int.Parse(Console.ReadLine()); // area
            var y = double.Parse(Console.ReadLine()); // production
            int z = int.Parse(Console.ReadLine()); // needed
            int workers = int.Parse(Console.ReadLine()); // workers

            
            var area = X * y;
            double production = 4 * area / 25;
            
                        
            if (production >= z && z >= 10 && workers >= 1)
            {

                double residue = Math.Ceiling(production - z);
                double litrePerWorkers = Math.Ceiling(residue / workers);
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Ceiling(production)} liters." +
                    $"\n{Math.Ceiling(residue)} liters left -> {Math.Ceiling(litrePerWorkers)} liters per person.");
                // pri izpisvane na nov red -->
            }

            if (production < z && z >= 10 && workers >= 1)
            {
                double residue = Math.Floor(z - production);
                Console.WriteLine($"It will be a tough winter! More {Math.Ceiling(residue)} liters wine needed.");
            }

        }
    }
}
