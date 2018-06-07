using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_calc_area_of_figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write b1, b3, h and see what happened, ");
            var b1 = int.Parse(Console.ReadLine());
            var b2 = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            var area = (b1 + b2) * h / 2.0;
            Console.WriteLine(area);

        }
    }
}
