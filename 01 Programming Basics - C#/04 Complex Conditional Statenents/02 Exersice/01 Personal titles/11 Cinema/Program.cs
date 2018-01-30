using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {

            string projection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            if (projection == "Premiere")
            {
                Console.WriteLine($"{row * column * 12.00:f2}");
            }

            else if (projection == "Normal")
            {
                Console.WriteLine($"{row * column * 7.50:f2}");
            }

            else if (projection == "Discount")
            {
                Console.WriteLine($"{row * column * 5.00:f2}");
            }

        }
    }
}
