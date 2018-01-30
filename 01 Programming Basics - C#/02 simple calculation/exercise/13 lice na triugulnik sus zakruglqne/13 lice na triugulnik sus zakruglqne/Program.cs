using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_lice_na_triugulnik_sus_zakruglqne
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = a * h / 2;
           
            // area = Math.Round(area, 2);

            //Console.WriteLine(Math.Round(area, 2));

            Console.WriteLine($"{area:f2}");
        }
    }
}
