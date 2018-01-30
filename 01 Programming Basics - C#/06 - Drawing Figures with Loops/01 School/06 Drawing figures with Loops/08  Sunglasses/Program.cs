using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08__Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            //first row
            Console.WriteLine("{0}{1}{0}", new string('*', 2*n), new string(' ', n));

            string slashes = new string('/', 2 * n - 2);
            string spaces = new string(' ', n);
            string pipes = new string('|', n);

            for (int row = 0; row < n - 2; row++)
            {
                if ((n % 2 == 0 && row == n/2 - 2)||(n % 2 == 1 && row == n/2 - 1 ))
                {
                    Console.WriteLine($"*{slashes}*{pipes}*{slashes}*");
                }
                else
                {
                    Console.WriteLine($"*{slashes}*{spaces}*{slashes}*");
                }
                
            }

            //last row
            Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));
        }
    }
}
