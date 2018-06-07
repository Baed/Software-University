using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
      
            var inner_top = 2 * n + 1;

            for (int i = 0; i < n; i++)
            {                
                inner_top -= 2;
                Console.WriteLine("{0}\\{1}/{0}", new string('*', i + 1), new string('-', inner_top));
            }

            var outer_mid = n / 2;
            var inner_mid = n + 2;

            for (int i = 0; i < n / 3; i++)
            {
                outer_mid++;
                inner_mid -=2;
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', outer_mid - 1), new string('*', inner_mid));
            }

            var inner_botton = 2 * n + 1;

            for (int i = 0; i < n; i++)
            {
                inner_botton -= 2;
                Console.WriteLine("{0}\\{1}/{0}", new string('-', i + 1), new string('*', inner_botton));
            }
        }
    }
}
