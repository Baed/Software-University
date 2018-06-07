using System;
using System.Collections.Generic;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double grapePerM2 = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            double totalGrape = area * grapePerM2;

            double totalWine = (totalGrape / 2.5) * 0.4;

            double leftWine = Math.Abs(totalWine - wineLiters);

            bool isWineEnough = totalWine >= wineLiters;

            if (isWineEnough)
            {
                Console.WriteLine
                    ($"Good harvest this year! Total wine: {Math.Floor(totalWine)} liters.");


                Console.WriteLine
                    ($"{Math.Ceiling(leftWine)} liters left -> {Math.Ceiling(leftWine / workers)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(leftWine)} liters wine needed.");
            }
        }
    }
}
