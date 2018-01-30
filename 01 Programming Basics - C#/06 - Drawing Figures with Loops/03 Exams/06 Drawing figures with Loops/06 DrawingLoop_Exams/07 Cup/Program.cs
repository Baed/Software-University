using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Cup
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var dot = n - 1;
            var sharp = 3 * n + 2 ;

            for (int i = 0; i < n / 2; i++)
            {
                dot++;
                sharp -= 2;
                Console.WriteLine("{0}{1}{0}", new string('.', dot), new string('#', sharp));
            }

            var outer_dot = n + n/2 - 1;
            var inner_dot = 3 * n - n;

            for (int i = 0; i < n / 2 + 1; i++)
            {
                outer_dot++;
                inner_dot -= 2;
                Console.WriteLine("{0}#{1}#{0}", new string('.', outer_dot), new string('.', inner_dot));           
            }

            Console.WriteLine("{0}{1}{0}", new string('.', 2 * n), new string('#', n));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', 2 * n - 2), new string('#', n + 4));
            }

            Console.WriteLine("{0}D^A^N^C^E^{0}", new string('.', 5 * n / 2 - 5));

            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', 2 * n - 2), new string('#', n + 4));
            }
        }
    }
}
