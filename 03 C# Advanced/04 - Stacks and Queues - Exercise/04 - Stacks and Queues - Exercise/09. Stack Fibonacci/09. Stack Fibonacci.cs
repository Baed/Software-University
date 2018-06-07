using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Stack_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var stack = new Stack<long>();

            for (int i = 0; i <= num; i++)
            {
                if (i < 3)
                {
                    stack.Push(1);
                }
                else
                {
                    long lastOut = stack.Pop();
                    long prevPeek = stack.Peek();

                    stack.Push(lastOut);

                    long currentNum = lastOut + prevPeek;
                    stack.Push(currentNum);
                }               
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
