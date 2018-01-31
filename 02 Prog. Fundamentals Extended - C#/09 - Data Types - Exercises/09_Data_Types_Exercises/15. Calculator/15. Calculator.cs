using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string operating = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            switch (operating)
            {
                case "+": Console.WriteLine($"{a} + {b} = {a + b}"); break;
                case "-": Console.WriteLine($"{a} - {b} = {a - b}"); break;
                case "*": Console.WriteLine($"{a} * {b} = {a * b}"); break;
                case "/": Console.WriteLine($"{a} / {b} = {a / b}"); break;
            }
        }
    }
}
