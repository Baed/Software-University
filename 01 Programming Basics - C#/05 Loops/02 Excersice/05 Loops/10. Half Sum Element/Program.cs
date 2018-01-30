using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var Sum = 0;
            int Max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                Max = number >= Max ? number : Max; // sukratena if konstrukciq 
                Sum += number;
            }

            Sum -= Max;

            if (Sum == Max)
            {
                Console.WriteLine($"Yes" + $"\nSum = {Sum}");
            }

            else
            {
                Console.WriteLine($"No" + $"\nDiff = {Math.Abs(Max - Sum)}");
            }

        }
    }
}
