using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Numbers_1toN_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i+= 3)
            {
                Console.WriteLine("The numbers are: {0}", i);
            }
        }
    }
}
