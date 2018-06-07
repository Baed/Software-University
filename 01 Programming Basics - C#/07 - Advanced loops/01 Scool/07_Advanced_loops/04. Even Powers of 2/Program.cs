using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            /* first type
            int num = 5;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(num);
                }
                num *= 2;
            }
            */

            /* second type
            int num = 1;
            for (int i = 0; i <= n; i += 2) // ili (int i = 0; i <= n/2; i ++)
            {
                Console.WriteLine(num);
                num *= 4;
            }
            */
            for (int i = 0; i <= n/2; i++)
            {
                Console.WriteLine(Math.Pow(4, i));
            }
        }
    }
}
