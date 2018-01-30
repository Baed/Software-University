using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var countT = 0;
            var countS = 0;
            var count = 0;
            for (int i = 1; i <= n; i++)
            {

                Console.Write(new string('*', i) + new string('\\', 1) + new string('-', (2 * n - 1) - count) + new string('/', 1) + new string('*', i));
                count = count + 2;
                Console.WriteLine();
            }
            for (int i = 0; i < n / 3; i++)
            {
                Console.Write(new string('|', 1) + new string('*', n / 2 + i) + new string('\\', 1) + new string('*', n - countS) + new string('/', 1) + new string('*', n / 2 + i) + new string('|', 1));
                countS = countS + 2;
                Console.WriteLine();
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('-', i) + new string('\\', 1) + new string('*', (2 * n - 1) - countT) + new string('/', 1) + new string('-', i));
                countT = countT + 2;
                Console.WriteLine();
            }
        }
    }
}
