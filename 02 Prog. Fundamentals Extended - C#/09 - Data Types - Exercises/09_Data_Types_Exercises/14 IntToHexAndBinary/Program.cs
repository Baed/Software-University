using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_IntToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var hex = num.ToString("X").ToUpper();
            var binary = Convert.ToString(num, 2);

            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}
