using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            /*
            for (int row = 0; row < n; row++)
            {
                Console.Write("*");

                for (int col = 0; col < n-1; col++) // n - 1 !!!!!
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }
            */

            // vtori nachin
            for (int row = 0; row < n; row++) // n !!!!!
            {
                //Console.Write("*");

                for (int col = 0; col < n; col++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
