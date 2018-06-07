using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Second_way__Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < 2 * n; i++) // 4eteme 2 * n chisla
            {
                int number = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    leftSum += number;
                }
                else
                {
                    rightSum += number;
                }

            }
            

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum =" + leftSum);
            }
            else
            {
                Console.WriteLine($"No, diff =" + Math.Abs(leftSum - rightSum));
            }
        }
    }
}
