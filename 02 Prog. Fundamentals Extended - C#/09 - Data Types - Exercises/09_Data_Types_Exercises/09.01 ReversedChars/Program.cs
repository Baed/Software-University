using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._01_ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] tokens = new char[3];

            for (int i = 0; i < tokens.Length; i++)
            {
                char inputLine = char.Parse(Console.ReadLine());
                tokens[i] = inputLine;
            }

            Console.WriteLine(tokens.Reverse().ToArray());
        }
    }
}
