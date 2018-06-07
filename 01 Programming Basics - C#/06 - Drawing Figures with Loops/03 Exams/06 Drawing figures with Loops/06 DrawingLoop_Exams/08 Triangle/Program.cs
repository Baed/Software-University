using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('#',4 * n + 1));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', i + 1), new string('#', 2 * n - 1 - 2 * i), new string(' ', 2 * i + 1));
            }

            Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', n/2 + 1), new string('#', 2 * n - 1 - n), new string(' ', n / 2 - 1));

        }
    }
}
