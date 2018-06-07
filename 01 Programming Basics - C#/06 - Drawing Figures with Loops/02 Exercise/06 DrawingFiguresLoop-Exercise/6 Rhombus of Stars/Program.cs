using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            //top part
            for (int vert = 1; vert <= n; vert++)
            {
                for (int spaces_Hor = 1; spaces_Hor <= n - vert; spaces_Hor++)
                {
                    Console.Write(" ");
                }
                for (int horiz = 1; horiz <= vert; horiz++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            // botton part
            for (int vert = 1; vert <= n - 1; vert++)
            {
                for (int spaces_Hor = 1; spaces_Hor <= vert; spaces_Hor++)
                {
                    Console.Write(" ");
                }
                for (int horiz = 1; horiz <= n - vert; horiz++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
