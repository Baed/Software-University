using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var width = 2 * n - 1;
            var high_part = n - 2;
            var LeftandRight = n - 1;

            for (int i = 0; i < high_part ; i++)
            {
                char symbol = i % 2 == 0 ? '*' : '-';

                Console.WriteLine("{0}\\ /{0}", new string(symbol, LeftandRight - 1));
            }

            Console.WriteLine("{0}@ ", new string(' ', LeftandRight));

            for (int i = 0; i < high_part; i++)
            {
                char symbol = i % 2 == 0 ? '*' : '-';

                Console.WriteLine("{0}/ \\{0}", new string(symbol, LeftandRight - 1));
            }
        }
    }
}
