using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_kushta
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = n;
            int starsCount = 1;

            if (n % 2 == 0)
            {
                starsCount++;
            }

            for (int row = 0; row < (n + 1) / 2; row++)
            {
                string dashes = new string('-', (width - starsCount) / 2);
                string stars = new string('*', starsCount);

                Console.WriteLine($"{dashes}{stars}{dashes}");
            }
        }
    }
}
