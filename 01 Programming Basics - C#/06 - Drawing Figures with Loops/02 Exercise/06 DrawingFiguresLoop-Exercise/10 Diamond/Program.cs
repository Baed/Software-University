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
            var dashes = new string('-', dashesCount);
            var stars = new string('*', starsCount);

            Console.WriteLine($"{dashes}{stars}{dashes}"); //first row

            for (int i = dashesCount - 1; i >= 0; i--)
            {
                var outerDashes = new string('-', i);
                var middleDashes = new string('-', n - 2 * i - 2);

                Console.WriteLine($"{outerDashes}*{middleDashes}*{outerDashes}");
            }



        }
    }
}
