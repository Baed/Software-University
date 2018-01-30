using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}/|\\{0}", new string('.', n * 2 - 1));
            Console.WriteLine("{0}\\|/{0}", new string('.', n * 2 - 1));

            for (int i = 0; i <= n * 2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', n * 2 - 1 - i), new string('-', i));
            }
            Console.WriteLine("{0}", new string('*', 4 * n + 1));

            for (int j = 0; j < (4 * n + 1) / 2; j++)
            {
                Console.Write("*.");                   
            }

            Console.WriteLine("*");                        
            Console.WriteLine("{0}", new string('*', 4 * n + 1));
        }
    }
}
