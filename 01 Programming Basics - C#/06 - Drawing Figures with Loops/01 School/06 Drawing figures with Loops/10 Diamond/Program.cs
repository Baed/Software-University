using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int starsCount = 1;

            if (n % 2 == 0)
            {
                starsCount++;
            }

            int dashesCount = (n - starsCount) / 2;
            string dashes = new string('-', dashesCount);
            string stars = new string('*', starsCount);

            Console.WriteLine("{0}{1}{0}", dashes, stars);

            for (int outerDashes = dashesCount - 1; outerDashes >= 0; outerDashes--)
            {
                string outer = new string('-', outerDashes);
                string middle = new string('-', n - 2 * outerDashes - 2 );

                Console.WriteLine($"{outer}*{middle}*{outer}");             
            }

            for (int outerDashesCount = 1; outerDashesCount < (n - 1) / 2; outerDashesCount++)
            {
                string outer = new string('-', outerDashesCount);
                string middle = new string('-', n - 2 * outerDashesCount - 2);

                Console.WriteLine($"{outer}*{middle}*{outer}");
            }

            if (n > 2)
            {
                Console.WriteLine("{0}{1}{0}", dashes, stars);
            }
            
        }
    }
}
