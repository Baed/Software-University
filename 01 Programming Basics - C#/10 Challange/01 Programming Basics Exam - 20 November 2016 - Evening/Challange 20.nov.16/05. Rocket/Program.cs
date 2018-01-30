using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var space = - 1;

            for (int i = 0; i < n; i++)
            {
                space += 2;
                Console.WriteLine("{0}/{1}\\{0}", new string('.', 3 * n / 2 - 1 - i), new string(' ', space - 1));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', n / 2 ), new string('*', n * 2));

            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', n / 2), new string('\\', 2 * n - 2));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', n  / 2 - i), new string('*', 2 * n - 2 + 2 * i));
            }
        }
    }
}
