using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //head up
            Console.WriteLine("{0}{1} {1}{0}", new string(' ', n + 1), new string('_', n/2 ));
            Console.WriteLine("{0}/{1}0{1}\\{0}", new string(' ', n), new string(' ', n / 2));

            //head bodi
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string(' ', n), new string(' ', n));
            }

            //head down
            Console.WriteLine("{0}\\{1}^{1}/{0}", new string(' ', n), new string('_', n / 2));

            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string(' ', n + 1), new string(' ', n));
            }

            Console.WriteLine("{0}\\{1}^{1}/{0}", new string(' ', n), new string('_', n / 2));

            for (int i = 0; i < n * 3; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string(' ', n), new string('-', n * 2));
            }
        }
    }
}
