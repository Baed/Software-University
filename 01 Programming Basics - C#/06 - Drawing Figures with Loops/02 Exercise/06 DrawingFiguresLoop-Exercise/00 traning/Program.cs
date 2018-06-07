using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_traning
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //top part
            for (int row = 1; row <= n; row++)
            {
                for (int spaces_Cow = 1; spaces_Cow <= n - row; spaces_Cow++)
                {
                    Console.Write(" ");
                }
                for (int cow = 1; cow <= row; cow++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            // botton part
            for (int row = 1; row <= n - 1; row++)
            {
                for (int spaces_Cow = 1; spaces_Cow <= row; spaces_Cow++)
                {
                    Console.Write(" ");
                }
                for (int cow = 1; cow <= n - row; cow++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
