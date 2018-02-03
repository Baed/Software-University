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
            Console.WriteLine(GetFibonacci(number));
            
        }


        private static int GetFibonacci(int number)
        {
            if (number < 2)
            {
                return 1;
            }

            return GetFibonacci(number - 1) + (number - 2);
        }

        private static int Reader()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}

