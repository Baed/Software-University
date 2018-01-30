using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // top part
            for (int row = 1; row <= n; row++)
            {
                for (int spaces = 0; spaces < n - row; spaces++)
                {
                    Console.Write(" ");
                }

                for (int stars = 0; stars < row; stars++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //botton part
            for (int i = 1; i <= n - 1; i++)
            {

                for (int spaces = 0; spaces < i; spaces++)
                {
                    Console.Write(" ");
                }
                for (int stars = 0; stars < n - i; stars++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
}
