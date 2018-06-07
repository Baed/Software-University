using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            /* FIRST VAR
           
            int n = int.Parse(Console.ReadLine());
            
            // first row
            Console.Write("+");

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }

            // middle part
            Console.WriteLine(" +");

            for (int row = 0; row < n - 2; row++)
            {
                Console.Write("|");

                for (int cow = 0; cow < n - 2; cow++)
                {
                    Console.Write(" -");
                }

                Console.WriteLine(" |");
            }
            
            
            // last row
            Console.Write("+");

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }

            Console.WriteLine(" +");
            */

            // SECOND VAR

            int n = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < n; i++)
            {
                char FirstAndLast = '|';

                if (i == 0 || i == n - 1)
                {
                    FirstAndLast = '+';
                }

                Console.Write(FirstAndLast);

                for (int cow = 0; cow < n - 2; cow++)
                {
                    Console.Write(" -");
                }

                //Console.WriteLine(" " + FirstAndLast);
            }
        }
    }
}
