using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal m = decimal.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            decimal start = n / 2;

            int counter = 0;
            while (true)
            {
                n -= m;
                counter++;
                if (y != 0)
                {
                    if (start == n)
                    {
                        n /= y;
                    }
                }
                if (n < m)
                {
                    break;
                }
            }

            Console.WriteLine(Math.Floor(n));

            Console.WriteLine(counter);
        }
    }
}
