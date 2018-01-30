using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Dot_in_border__rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            bool Verticalside = y > y1 && y <= y2 && (x == x1 || x == x2); // vajni sa skobite za kombinirane

            bool Horizontalside = x > x1 && x <= x2 && (y == y1 || y == y2);

            //bool leftborder = x == x1 && y > y1 && y <= y2;
            //bool rightborder = x == x2 && y > y1 && y <= y2;

            //bool topborder = y == y1 && x> x1 && x <= x2;
            //bool downborder = y == y2 && x > x1 && x <= x2;

            //bool border = leftborder || rightborder || topborder || downborder;

            bool border = Verticalside || Horizontalside;

            if (border)
            {
                Console.WriteLine("Border");
            }

            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
