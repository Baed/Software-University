using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var ctr = 1;

            while (ctr <= 10)
            {
                Console.WriteLine($"{n} X {ctr} = {n * ctr}");
                ctr++;
            }
        }
    }
}
