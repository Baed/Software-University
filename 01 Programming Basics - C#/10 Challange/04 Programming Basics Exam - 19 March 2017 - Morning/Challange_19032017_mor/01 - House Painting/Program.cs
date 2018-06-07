using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            var behind_wall = x * x;
            var frond_wall = behind_wall - 1.2 * 2;
            var side_wall = 2 * (x * y - 1.5 * 1.5);
            var roof = 2 * x * y + x * h;

            Console.WriteLine($"{(behind_wall + frond_wall + side_wall)/3.4:f2}");
            Console.WriteLine($"{roof / 4.3:f2}");



        }
    }
}
