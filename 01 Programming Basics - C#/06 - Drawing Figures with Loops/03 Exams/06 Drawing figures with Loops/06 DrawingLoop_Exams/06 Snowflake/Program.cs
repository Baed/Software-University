using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var outer_top = - 1;
            var inner_top = n + 1;

            for (int i = 0; i < n - 1; i++)
            {
                outer_top++;
                inner_top--;               
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', outer_top), new string('.', inner_top));
            }

               Console.WriteLine("{0}{1}{0}", new string('.', (2 * n - 1)/2), new string('*', 5));
               Console.WriteLine("{0}", new string('*', 2 * n + 3));
               Console.WriteLine("{0}{1}{0}", new string('.', (2 * n - 1) / 2), new string('*', 5));


            var outer_botton = n - 1;
            var inner_botton = 1;

            for (int i = 0; i < n - 1; i++)
            {
                outer_botton--;
                inner_botton++;
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', outer_botton), new string('.', inner_botton));
            }

        }
    }
}
