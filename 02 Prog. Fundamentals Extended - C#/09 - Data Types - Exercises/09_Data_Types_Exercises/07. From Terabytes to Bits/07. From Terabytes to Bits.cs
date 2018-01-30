using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.From_Terabytes_to_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal terraBytes = n * (1024m * 1024 * 1024 * 1024 * 8);
            Console.WriteLine($"{terraBytes:f0}");
        }
    }
}
