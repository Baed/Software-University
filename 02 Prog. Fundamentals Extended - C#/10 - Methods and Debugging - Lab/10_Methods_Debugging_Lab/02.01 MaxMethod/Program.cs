using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._01_MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = ReadInput();
            int maxNumber = ExecuteProgram(numbers);
            Printer(maxNumber);
        }

        private static int ExecuteProgram(int[] numbers)
        {
            int result = GetMax(numbers);

            return result;
        }

        private static void Printer(int result)
        {
            Console.WriteLine(result);
        }

        private static int GetMax(int[] numbers)
        {
            int maxNum = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (maxNum < numbers[i])
                {
                    maxNum = numbers[i];
                }
            }

            return maxNum;
        }

        private static int[] ReadInput()
        {
            int[] numbers = new int[3];

            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            return numbers;
        }
    }
}

