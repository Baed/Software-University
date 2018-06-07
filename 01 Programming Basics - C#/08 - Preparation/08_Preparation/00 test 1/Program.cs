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

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1}", new string(' ', n - i), new StringBuilder().Insert(0, "* ", i));              
            }
            for (int i = 1; i <= n - 1; i++)
            {
                Console.WriteLine("{0}{1}", new string(' ', i), new StringBuilder().Insert(0, "* ", n - i));
            }
        }
    }
}
