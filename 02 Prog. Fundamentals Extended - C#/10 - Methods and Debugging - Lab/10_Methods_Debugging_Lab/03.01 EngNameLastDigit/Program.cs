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
            string number = Reader();
            string result = ExecuteProgram(number);
            Printer(result);
        }

        private static void Printer(string result)
        {
            Console.WriteLine(result);
        }

        private static string ExecuteProgram(string number)
        {         
            string[] digitName = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            string lastDigit = number.Substring(number.Length - 1);

            int index = int.Parse(lastDigit);

            string result = digitName[index];

            return result;
        }

        private static string Reader()
        {
            return Console.ReadLine();
        }
    }
}
