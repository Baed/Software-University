using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            Stack<int> maxNumbers = new Stack<int>();

            int maxElement = int.MinValue;

            for (int i = 0; i < cnt; i++)
            {
                int[] tokens = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int command = tokens[0];
                int numToPush = tokens[1];

                if (command.Equals(1))
                {                  
                    stack.Push(numToPush);

                    if (numToPush >= maxNumbers.Peek())
                    {
                        maxNumbers.Push(numToPush);
                    }
                }
                else if (command.Equals(2))
                {
                    if (stack.Count > 0)
                    {
                        int elementAtTop = stack.Pop();
                        int currentMaxNumber = maxNumbers.Peek();

                        if (elementAtTop == currentMaxNumber)
                        {
                            maxNumbers.Pop();
                        }
                    }
                }
                else if (command.Equals(3))
                {
                    Console.WriteLine(maxNumbers.Peek());
                }
            }
        }
    }
}
