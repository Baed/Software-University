using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            decimal totalYears = 0;

            for (int i = 0; i < n; i++)
            {
                long amountFenixes = long.Parse(Console.ReadLine());
                decimal width = decimal.Parse(Console.ReadLine());
                long length = long.Parse(Console.ReadLine());

                totalYears = (decimal)Math.Pow(amountFenixes, 2) * (width + 2 * length);

                Console.WriteLine($"{totalYears}");
            }

        }
    }
}
