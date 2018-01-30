using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Numbers_to_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumbers = int.Parse(Console.ReadLine());
            string outputMessage = string.Empty;

            for (int i = 0; i < inputNumbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber >= 0 && currentNumber < 100) continue;
                else if (currentNumber > 999)
                {
                    Console.WriteLine("too large");
                    continue;
                }
                else if (currentNumber < -999)
                {
                    Console.WriteLine("too small");
                    continue;
                }

                string message = currentNumber < 0 ? "minus " : string.Empty;

                outputMessage = Leterize(Math.Abs(currentNumber));

                Console.WriteLine(message + outputMessage);
            }
        }
        static string Leterize(int number)
        {
            string[] toTens = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            string[] teens = { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            string outputMessage = toTens[number / 100] + "-hundred";

            if (number % 100 == 0)
            {
                return outputMessage;
            }
            else if (number % 100 <= 10)
            {
                return outputMessage = outputMessage + " and " + toTens[number % 100];
            }
            else if (number % 100 > 10 && number % 100 <= 19)
            {
                return outputMessage = outputMessage + " and " + teens[number % 10];
            }
            else if (number % 10 == 0)
            {
                return outputMessage = outputMessage + " and " + tens[number % 100 / 10];
            }
            else
            {
                return outputMessage = outputMessage + " and " + tens[number % 100 / 10] + " " + toTens[number % 10]; ;
            }
        }
    }
}
