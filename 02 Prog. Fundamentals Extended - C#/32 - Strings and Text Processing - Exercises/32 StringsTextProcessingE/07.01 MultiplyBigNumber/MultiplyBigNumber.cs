using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._01_MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine().TrimStart('0');

            string secondNumberAsString = Console.ReadLine();

            int secondNumber = int.Parse(secondNumberAsString);

            StringBuilder sb = new StringBuilder();

            int reminder = 0;
            int multiply = 0;

            if (secondNumber == 0)
            {
                Console.WriteLine("0");
                return;
            }

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(firstNumber[i].ToString());

                multiply = digit * secondNumber + reminder;
                reminder = 0;

                if (multiply > 9)
                {
                    reminder = multiply / 10;
                    multiply %= 10;
                }

                if (sb.Length < 1)
                {
                    sb.Append(multiply);
                }
                else
                {
                    sb.Insert(0, multiply);
                }
            }
            if (reminder > 0)
            {
                sb.Insert(0, reminder);
            }

            Console.WriteLine(string.Join("", sb));
        }
    }
}
