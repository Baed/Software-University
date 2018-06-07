using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Grape_and_Rakia
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double kg = double.Parse(Console.ReadLine());
            double waste = double.Parse(Console.ReadLine());

            var product = area * kg;
            var overage = product - waste;

            Console.WriteLine($"{overage * 0.45 / 7.5 * 9.8:f2}");
            Console.WriteLine($"{overage*0.55*1.5:f2}");
        }
    }
}

