using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._01_ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            var difference = Math.Abs(a - b);
            var eps = 0.000001;

            if (difference >= eps)
            {
                Console.WriteLine(false);
            }
            else if (difference < eps)
            {
                Console.WriteLine(true);
            }
        }
    }
}
