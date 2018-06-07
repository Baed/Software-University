using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter H: ");
            int h = int.Parse(Console.ReadLine());
            //Console.Write("Enter X: ");
            int x = int.Parse(Console.ReadLine());
            //Console.Write("Enter Y: ");
            int y = int.Parse(Console.ReadLine());

            var x1 = 0;
            var x2 = 3 * h;
            var y1 = 0;
            var y2 = h;

            var x3 = h;
            var x4 = h * 2;
            var y3 = h;
            var y4 = h * 4;

            if ((x > x1 && x < x2 && y > y1 && y < y2) 
                || (x > x3 && x < x4 && y > y3 && y < y4) 
                || (x > h && x < h * 2 && (y == y2 || y == y3))) // obshtata strana
            {
                Console.WriteLine("inside");
            }

            else if ((x >= x1 && x <= x2 && (y == y1 || y == y2)) 
                || (y1 <= y && y <= y2 && (x == x1 || x == x2)) 
                || (x >= x3 && x <= x4 && (y == y3 || y == y4)) 
                || (y3 <= y && y <= y4 && (x == x3 || x == x4)))
            {
                Console.WriteLine("border");
            }

            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
