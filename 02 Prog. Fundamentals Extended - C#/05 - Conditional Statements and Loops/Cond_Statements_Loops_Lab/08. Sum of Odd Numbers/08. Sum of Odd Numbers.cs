using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var ctr = 1;
            var sum = 0;
            for (int i = 1; i <= n; i ++)
            {               
                Console.WriteLine(ctr);
                ctr += 2;
                sum++;
            }
            Console.WriteLine($"Sum: {sum * n}");
            
            /* second way
            var sum = 0;

            for (var i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.WriteLine($"Sum:{sum}");
            */
        }
    }
}
