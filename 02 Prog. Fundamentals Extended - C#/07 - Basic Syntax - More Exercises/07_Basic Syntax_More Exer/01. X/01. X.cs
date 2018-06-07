using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < (n - 1)/2; i++)
            {
                Console.WriteLine("{0}x{1}x{0}", new string(' ', i), new string(' ', n - 2 - 2 * i));
            }
            Console.WriteLine("{0}x{0}", new string(' ', (n - 1) / 2));
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.WriteLine("{0}x{1}x{0}", new string(' ', (n - 3)/2 - i ), new string(' ', 1 + 2 * i));
            }
        }
    }
}
