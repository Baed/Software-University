using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DecimalToBinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine()); // 10
            var stack = new Stack<int>();

            if (number == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (number != 0)
                {
                    stack.Push(number % 2); // 10 --> 10 % 2 = 0
                    number /= 2; // 10 / 2 = 5 --> 5 % 2 = 1 
                }
                while (stack.Count > 0)
                {
                    Console.Write(stack.Pop()); // FIFO 0101 --> 1010
                }               
            }
            Console.WriteLine();
        }
    }
}
