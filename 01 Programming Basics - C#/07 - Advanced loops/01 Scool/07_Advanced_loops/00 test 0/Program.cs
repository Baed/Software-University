using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_test_0
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sidedashes = n / 2 - 1;
            var middledashes = 0;


            if (n % 2 == 0)
            {
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', sidedashes), new string('-', middledashes));
                    sidedashes -= 1;
                    middledashes += 2;
                }
                Console.WriteLine("*{0}*", new string('-', middledashes));
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    sidedashes += 1;
                    middledashes -= 2;
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', sidedashes), new string('-', middledashes));
                }
            }
            else if (n % 1 == 0 && n != 1)
            {
                Console.WriteLine("{0}*{0}", new string('-', sidedashes + 1));
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', sidedashes), new string('-', middledashes + 1));
                    sidedashes -= 1;
                    middledashes += 2;
                }
                Console.WriteLine("*{0}*", new string('-', middledashes + 1));
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    sidedashes += 1;
                    middledashes -= 2;
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', sidedashes), new string('-', middledashes + 1));
                }
                Console.WriteLine("{0}*{0}", new string('-', sidedashes + 1));

            }
            if (n == 1)
            {
                Console.WriteLine("*");
            }
        }
    }
}
