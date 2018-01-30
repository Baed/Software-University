using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(' ');
            var stack = new Stack<string>(inputLine.Reverse());

            while (stack.Count > 1)
            {
                int firstNumber = int.Parse(stack.Pop());
                string operation = stack.Pop();
                int secondNumber = int.Parse(stack.Pop());

                switch (operation)
                {
                    case "+": stack.Push((firstNumber + secondNumber).ToString()); break;
                    case "-": stack.Push((firstNumber - secondNumber).ToString()); break;
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
