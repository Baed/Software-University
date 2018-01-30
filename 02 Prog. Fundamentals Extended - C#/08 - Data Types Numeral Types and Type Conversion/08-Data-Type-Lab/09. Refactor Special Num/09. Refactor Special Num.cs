using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int digits = 0;           

            for (int num = 1; num <= n; num++)
            {
                digits = num;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{digits} -> {isSpecial}");
                sum = 0; // restart za sledvashtoto zavurtane
                num = digits; // restart za sledvashtoto zavurtane
            }
        }
    }
}
