using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
                /* loop old
                int result = 1;
                for (int inner = 0; inner < i; inner++)
                {
                    result *= 2;
                }
                Console.WriteLine(result);
                */
            }       
        }
    }
}
