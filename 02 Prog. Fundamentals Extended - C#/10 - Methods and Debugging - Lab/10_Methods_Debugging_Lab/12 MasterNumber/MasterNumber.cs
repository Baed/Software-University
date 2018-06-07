using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_MasterNumber
{
    class MasterNumber
    {
        static void Main(string[] args)
        {
            int number = Reader();
            ExecuteProgram(number);
        }

        private static void ExecuteProgram(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (IsContainsEvenDigit(i) && IsSumDivisibleBySeven(i) && IsPalindrome(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsContainsEvenDigit(int number)
        {
            while (number > 0)
            {
                int digitToCheck = number % 10;

                if (digitToCheck % 2 == 0)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }

        private static bool IsSumDivisibleBySeven(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }

            return false;
        }

        private static bool IsPalindrome(int number)
        {
            string digits = number.ToString();

            for (int i = 0; i < digits.Length / 2; i++)
            {
                if (digits[i] != digits[digits.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        private static int Reader()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
