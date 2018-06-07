using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Dot_in_Triangle
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

            bool Yinside = y >= y1 && y <= y2;
            bool Xinside = x >= x1 && x <= x2;
            bool XYinside= Yinside && Xinside;

            /* Sukraten variant
             if (y >= y1 && y <= y2 && x >= x1 && x <= x2)
             {
               Console.WriteLine("Inside");
             }
             else
             {
               Console.WriteLine("Outside");
             }
             */

            if (XYinside)
            {
                Console.WriteLine("Inside");
            }

            else 
            {
                Console.WriteLine("Outside");
            }

            
        }
    }
}
