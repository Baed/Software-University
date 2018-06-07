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


            for (int row = 0; row < n; row++)
            {
                for (int cow = 0; cow < n; cow++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
