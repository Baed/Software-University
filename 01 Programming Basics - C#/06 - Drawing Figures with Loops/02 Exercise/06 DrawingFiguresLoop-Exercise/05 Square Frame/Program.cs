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
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var symbol = "| ";

                if (i == 0 || i == n - 1)
                {
                    symbol = "+ ";
                }
                Console.Write(symbol);

                for (int cow = 0; cow < n - 2; cow++)
                {         
                   Console.Write("- ");
                }

                Console.WriteLine(symbol);
            }

            Console.WriteLine();
        }
    }
}
