using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _13_Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int number = Printer();
            BigInteger result = ExecuteProgram(number);
            Writer(result);
        }

        private static void Writer(BigInteger result)
        {
            Console.WriteLine(result);
        }

        private static BigInteger ExecuteProgram(int number)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }

        private static int Printer()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
