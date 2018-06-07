using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (var @char in input)
            {
                stack.Push(@char);
            }
            foreach (var item in input)
            {
                Console.Write(stack.Pop());
            }

            /*
             
            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(stack.Pop());
            }

            */
            Console.WriteLine();
        }
    }
}
