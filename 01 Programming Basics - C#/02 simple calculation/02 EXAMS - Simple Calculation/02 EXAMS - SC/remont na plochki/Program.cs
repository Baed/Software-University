using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remont_na_plochki
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = double.Parse(Console.ReadLine()); //square area
            var W= double.Parse(Console.ReadLine()); // width plochka
            var L = double.Parse(Console.ReadLine()); // lenght plochka
            var M = double.Parse(Console.ReadLine()); // width peika
            var O = double.Parse(Console.ReadLine()); // lenght peika
            var time = 0.2;
            var square = N * N;
            var tile = W * L;
            var bench = M * O;
            var resultTile = ((square - bench)/tile);  // plochki
            var resultTime = (resultTile * time);
            Console.WriteLine($"{resultTile:f2}");
            Console.WriteLine($"{resultTime:f2}");

        }
    }
}
