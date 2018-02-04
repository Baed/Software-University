using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _14_FactTrailingZero
{
    class FactTrailingZero
    {
        static void Main(string[] args)
        {
            int number = Printer();
            int result = ExecuteProgram(number);
            Writer(result);
        }

        private static void Writer(int result)
        {
            Console.WriteLine(result);
        }

        private static int ExecuteProgram(int number)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

            int zeroes = GetZeroes(factorial);

            return zeroes;
        }

        private static int GetZeroes(BigInteger factorial)
        {
            string digits = factorial.ToString();

            int cnt = 0;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (int.Parse(digits[i].ToString()).Equals(0))
                {
                    cnt++;
                }
                else
                {
                    break;
                }
            }

            return cnt;
        }

        private static int Printer()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
