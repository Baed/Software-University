using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Sheriff
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var dot = n / 2 + 1;
            var ex = n - 1;

            Console.WriteLine("{0}x{0}", new string('.', n * 3/2));
            Console.WriteLine("{0}/x\\{0}", new string('.', n* 3/2 - 1 ));
            Console.WriteLine("{0}x|x{0}", new string('.', n * 3/2 - 1));

            for (int i = 0; i < n /2 + 1; i++)
            {
                dot--;
                ex++;
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', dot), new string('x', ex));
            }
            for (int i = 0; i < n/2; i++)
            {
                dot++;
                ex--;
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', dot), new string('x', ex));
            }

            Console.WriteLine("{0}/x\\{0}", new string('.', n * 3/2 - 1));
            Console.WriteLine("{0}\\x/{0}", new string('.', n * 3/2 - 1));

            var dot_down = n / 2 + 1;
            var ex_down = n - 1;

            for (int i = 0; i < n / 2 + 1; i++)
            {
                dot_down--;
                ex_down++;
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', dot_down), new string('x', ex_down));
            }
            for (int i = 0; i < n / 2; i++)
            {
                dot_down++;
                ex_down--;
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', dot_down), new string('x', ex_down));
            }

            Console.WriteLine("{0}x|x{0}", new string('.', n * 3/2 - 1));
            Console.WriteLine("{0}\\x/{0}", new string('.', n * 3/2 - 1));
            Console.WriteLine("{0}x{0}", new string('.', n * 3/2));
        }
    }
}
