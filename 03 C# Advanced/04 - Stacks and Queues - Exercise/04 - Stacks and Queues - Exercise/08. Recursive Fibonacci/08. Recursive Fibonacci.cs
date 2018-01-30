using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Recursive_Fibonacci
{
    class Program
    {
        static long[] fibonacciNums;

        static void Main(string[] args)
        {
            long numbers = long.Parse(Console.ReadLine());
            fibonacciNums = new long[numbers];

            var result = GetFibonacci(numbers);

            Console.WriteLine(result);
        }

        private static long GetFibonacci(long number)
        {
            if (number <= 2)
            {
                return 1;
            }
            if (fibonacciNums[number - 1] != 0) // lenght = [number - 1]
            {
                return fibonacciNums[number - 1];
            }
            return fibonacciNums[number - 1] = GetFibonacci(number - 1) + GetFibonacci(number - 2);
        }
    }
}
