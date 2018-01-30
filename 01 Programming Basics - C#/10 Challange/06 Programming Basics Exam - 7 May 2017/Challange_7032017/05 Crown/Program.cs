using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("@{0}@{0}@", new string(' ',n - 2));
            Console.WriteLine("**{0}*{0}**", new string(' ', n - 3));
            
            for (int i = 0; i < n / 2 - 2; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', i + 1), new string(' ', n - 5 - 2 * i), new string('.', 1 + 2 * i));
            }
            Console.WriteLine("*{0}*{1}*{0}*", new string('.', n/2 - 1), new string('.', n - 3));
            Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', n / 2), new string('*', n / 2 - 2));
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0}", new string('*', 2 * n - 1));
            }
            
        }
    }
}
