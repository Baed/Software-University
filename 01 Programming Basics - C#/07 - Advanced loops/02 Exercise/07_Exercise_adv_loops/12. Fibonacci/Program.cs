using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var first = 1;
           var second = 1;

            for (int i = 2; i <= n; i++)
            {
                var sum_fibunacci = first + second;
                first = second;
                second = sum_fibunacci;

            }
            Console.WriteLine(second);
        }
    }
}
