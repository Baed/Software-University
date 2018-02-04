using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._01_FibonacciNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Reader();
            int fibonacciNum = (GetFibonacci(number));
            Writer(fibonacciNum);
        }

        private static void Writer(int fibonacciNum)
        {
            Console.WriteLine(fibonacciNum);
        }

        private static int GetFibonacci(int number)
        {
            int firstNum = 0;
            int secNum = 1;
            int fibonacciNum = 0;

            if (number < 2)
            {
                return 1;
            }

            for (int i = 0; i < number; i++)
            {
                fibonacciNum = firstNum + secNum;
                firstNum = secNum;
                secNum = fibonacciNum;
            }


            return fibonacciNum;
        }

        private static int Reader()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}

