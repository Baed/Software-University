using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            var min_num = Math.Min(a, b);
            var max_num = Math.Max(a, b);

            while (min_num != 0)
            {
                var next_small_num = max_num % min_num;
                max_num = min_num;
                min_num = next_small_num;
            }
            Console.WriteLine(max_num);
        }
    }
}
