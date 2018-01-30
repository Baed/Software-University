using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            double OddSum = 0.0;
            double OddMin = double.MaxValue;
            double OddMax = double.MinValue;

            double EvenSum = 0.0; 
            double EvenMin = double.MaxValue;
            double EvenMax = double.MinValue;

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    OddSum += number;

                    if (number < OddMin)
                    {
                        OddMin = number;
                    }

                    else if (number > OddMax)
                    {
                        OddMax = number;
                    }

                }
                else
                {
                    EvenSum += number;

                    if (number < EvenMin)
                    {
                        EvenMin = number;
                    }
                    else if (number > EvenMax)
                    {
                        EvenMax = number;
                    }

                }
            }
            Console.WriteLine($"OddSum = {OddSum},");
            if (OddMin == double.MaxValue)
            {
                Console.WriteLine($"OddMin = {OddMin},");
            }
            else
            {
                Console.WriteLine($"OddMin = No,");
            }
            
            if (OddMax == double.MinValue)
            {
                Console.WriteLine($"OddMax = {OddMax},");
            }
            else
            {
                Console.WriteLine($"OddMax = No,");
            }
            Console.WriteLine($"EvenSum = {EvenSum},");
            if (EvenMin == double.MaxValue)
            {
                Console.WriteLine($"EvenMin = {EvenMin},");
            }
            else
            {
                Console.WriteLine($"EvenMin = No,");
            }
            if (EvenMax == double.MinValue)
            {
                Console.WriteLine($"EvenMax = {EvenMax},");
            }
            else
            {
                Console.WriteLine($"EvenMax = No");
            }
            
        }
    }   
}
