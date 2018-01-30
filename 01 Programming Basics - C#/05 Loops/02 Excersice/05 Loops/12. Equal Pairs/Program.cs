using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var prev_Sum = 0;
            var max_Diff = 0;

            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                var Current_Sum = num1 + num2;


                if (prev_Sum != Current_Sum && i > 0)
                {
                    int diff = Math.Abs(Current_Sum - prev_Sum);

                    if (diff > max_Diff)
                    {
                        max_Diff = diff;
                    }
                }

                prev_Sum = Current_Sum;

            }

            if (max_Diff == 0)
            {
                Console.WriteLine($"Yes, value={prev_Sum}");
            }

            else
            {
                Console.WriteLine($"No, maxdiff={max_Diff}");
            }
        }
    }
}
