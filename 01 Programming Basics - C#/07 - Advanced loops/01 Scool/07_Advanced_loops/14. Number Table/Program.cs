using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col <= n; col++)
                {
                    Console.Write("{0} ", col);
                }

                for (int col = n - 1; col > n - row; col--)
                {
                    Console.Write("{0} ", col);
                }
                Console.WriteLine();
            }
        }
    }
}
