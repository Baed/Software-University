using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._01_HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = GetInput();

            ExecuteCommand(input);
        }

        private static void ExecuteCommand(string input)
        {
            Console.WriteLine($"Hello, {input}!");
        }

        private static string GetInput()
        {
            return Console.ReadLine();
        }
    }
}
