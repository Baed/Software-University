using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_zakruglqne_na_ìsla
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(num, 2));

            //Console.WriteLine(Math.Floor(num)); - down

            //Console.WriteLine(Math.Ceiling(num)); - up

        }
    }
}
