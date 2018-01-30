using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Distance_of_the_Stars
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal kmPerLY = 9450000000000m;
            decimal proximaCentury = kmPerLY * 4.22m;
            decimal center = kmPerLY * 26000;
            decimal milkyWay = kmPerLY * 100000;
            decimal edgeOfGalaxy = kmPerLY * 46500000000;

            Console.WriteLine($"{proximaCentury:e2}\n{center:e2}\n{milkyWay:e2}\n{edgeOfGalaxy:e2}");

        }
    }
}
