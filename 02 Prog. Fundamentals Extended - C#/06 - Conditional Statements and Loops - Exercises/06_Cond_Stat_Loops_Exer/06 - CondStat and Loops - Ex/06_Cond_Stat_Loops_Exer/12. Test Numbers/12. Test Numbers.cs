using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            var sum = 0;
            var combination = 0; 
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {       
                    if (sum >= max)
                    {                     
                        break;
                    }
                    sum += 3 * (i * j);
                    combination++;
                }
            }
            Console.WriteLine($"{combination} combinations");
            if (sum >= max)
            {
                Console.WriteLine($"Sum: {sum} >= {max}");
            }
            else
            {
                Console.WriteLine($"Sum: {sum}");
            }
            
        }
    }
}
