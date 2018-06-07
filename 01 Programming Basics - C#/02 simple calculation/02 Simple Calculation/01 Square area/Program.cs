using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Square_area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate square area");
            Console.Write("Enter parameter 'a' = ");
            var a = double.Parse(Console.ReadLine());
            var area = a * a;
            Console.WriteLine("area is = {0}", area);
        }
    }
}
