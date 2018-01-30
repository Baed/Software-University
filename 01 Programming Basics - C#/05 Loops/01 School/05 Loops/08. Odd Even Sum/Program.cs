using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int EvenSum = 0;
            int OddSum = 0;


            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    EvenSum += number;
                }

                else
                {
                    OddSum += number;
                }

            }

            if (EvenSum == OddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + EvenSum);
            }

            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(EvenSum - OddSum));
            }
        }
    }
}
