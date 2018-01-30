using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int five = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= one; i++)
            {
                for (int j = 0; j <= two; j++)
                {
                    for (int k = 0; k <= five; k++)
                    {
                        if (1 * i + 2 * j + 5 * k == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }

            
        }
    }
}
