using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._01_EngNameLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Reader();
            string result = ExecuteProgram(number);
            Printer(result);
        }

        private static void Printer(string result)
        {
            Console.WriteLine(result);
        }

        private static string ExecuteProgram(int number)
        {
            string result = string.Empty;

            string[] digitName = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            int lastDigit = number % 10;

            result = digitName[lastDigit];

            return result;
        }

        private static int Reader()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
