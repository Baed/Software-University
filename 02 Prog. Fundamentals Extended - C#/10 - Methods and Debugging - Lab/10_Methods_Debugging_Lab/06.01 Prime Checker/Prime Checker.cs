using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _06._01_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {

            long number = Reader();
            bool result = ExecuteProgram(number);
            Printer(result);
        }

        private static void Printer(bool result)
        {
            Console.WriteLine(result);
        }

        private static bool ExecuteProgram(long number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static long Reader()
        {
            return long.Parse(Console.ReadLine());
        }
    }
}
