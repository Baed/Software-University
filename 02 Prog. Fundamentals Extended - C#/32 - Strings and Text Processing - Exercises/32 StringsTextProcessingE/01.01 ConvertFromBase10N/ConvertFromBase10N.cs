using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01._01_ConvertFromBase10N
{
    class ConvertFromBase10N
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(BigInteger.Parse).ToList();

            BigInteger bases = input[0];
            BigInteger number = input[1];

            List<BigInteger> solution = new List<BigInteger>();

            while (number > 0)
            {
                BigInteger remainder = number % bases;
                solution.Add(remainder);
                number /= bases;
            }
            solution.Reverse();
            Console.WriteLine(string.Join("", solution));
        }
    }
}
