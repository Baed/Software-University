using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int lastDigit = number % 10;

            string result = String.Empty;

            if (number == 0)
            {
                result = "zero";
            }
            else if (number > 100 || number < 0)
            {
                result = "invalid number";

                Console.WriteLine(result.Trim());
                return;
            }
            else if (number == 100)
            {
                result = "one hundred";
            }
            else if ((number >= 10 && number <= 13) || number == 15)
            {
                switch (number)
                {
                    case 10:
                        result = "ten";
                        break;
                    case 11:
                        result = "eleven";
                        break;
                    case 12:
                        result = "twelve";
                        break;
                    case 13:
                        result = "thirteen";
                        break;
                    case 15:
                        result = "fifteen";
                        break;
                }

                Console.WriteLine(result.Trim());
                return;
            }
            else if (number == 14 || (number >= 16 && number <= 19))
            {
                switch (number)
                {
                    case 14:
                        result = "four";
                        break;
                    case 16:
                        result = "six";
                        break;
                    case 17:
                        result = "seven";
                        break;
                    case 18:
                        result = "eight";
                        break;
                    case 19:
                        result = "nine";
                        break;
                }

                result += "teen";

                Console.WriteLine(result.Trim());
                return;
            }
            else if (number >= 20 && number < 100)
            {
                int firstDigit = number / 10;

                switch (firstDigit)
                {
                    case 2:
                        result = "twenty ";
                        break;
                    case 3:
                        result = "thirty ";
                        break;
                    case 4:
                        result = "forty ";
                        break;
                    case 5:
                        result = "fifty ";
                        break;
                    case 6:
                        result = "sixty ";
                        break;
                    case 7:
                        result = "seventy ";
                        break;
                    case 8:
                        result = "eighty ";
                        break;
                    case 9:
                        result = "ninety ";
                        break;

                }
            }
            if (lastDigit >= 1 && lastDigit <= 9)
            {
                switch (lastDigit)
                {
                    case 1:
                        result += "one";
                        break;
                    case 2:
                        result += "two";
                        break;
                    case 3:
                        result += "three";
                        break;
                    case 4:
                        result += "four";
                        break;
                    case 5:
                        result += "five";
                        break;
                    case 6:
                        result += "six";
                        break;
                    case 7:
                        result += "seven";
                        break;
                    case 8:
                        result += "eight";
                        break;
                    case 9:
                        result += "nine";
                        break;
                }
            }

            Console.WriteLine(result.Trim());
        }
    }
}
