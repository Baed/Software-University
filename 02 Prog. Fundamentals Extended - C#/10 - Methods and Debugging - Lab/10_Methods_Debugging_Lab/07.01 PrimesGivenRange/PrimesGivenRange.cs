using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _07._01_PrimesGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Reader();
            List<int> result = ExecuteProgram(numbers);
            Printer(result);

        }

        private static void Printer(List<int> result)
        {
            Console.WriteLine(string.Join(", ", result.ToList()));
        }

        private static List<int> ExecuteProgram(List<int> numbers)
        {
            List<int> result = new List<int>();

            for (int i = numbers[0]; i <= numbers[1]; i++)
            {
                bool isPrime = true;

                if (i < 2)
                {
                    isPrime = false;
                }
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    result.Add(i);
                }
            }

            return result;
        }

        private static List<int> Reader()
        {
            List<int> numbers = new List<int>();
            numbers.Add(int.Parse(Console.ReadLine()));
            numbers.Add(int.Parse(Console.ReadLine()));

            return numbers;
        }
    }
}
