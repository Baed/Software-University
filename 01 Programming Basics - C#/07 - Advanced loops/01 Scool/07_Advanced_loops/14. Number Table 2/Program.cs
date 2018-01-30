using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Number_Table_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int num = col + row;

                    if (num > n)
                    {
                        int calc = 2 * n - num;
                        Console.Write("{0} ", calc);
                    }
                    else
                    {
                        Console.Write("{0} ", num);
                    }
                                      
                }

                Console.WriteLine();
            }
        }
    }
}
