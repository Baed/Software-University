using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Operation_between_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var N1 = int.Parse(Console.ReadLine());
            var N2 = int.Parse(Console.ReadLine());
            var symbol = char.Parse(Console.ReadLine());

           

            if (symbol == '+')
            {
                Console.WriteLine($"{N1} + {N2} = {N1 + N2} - " + ((N1 + N2) % 2 == 0 ? "even" : "odd"));
            }

            if (symbol == '-')
            {
                Console.WriteLine($"{N1} - {N2} = {N1 - N2} - " + ((N1 - N2) % 2 == 0 ? "even" : "odd"));
            }

            if (symbol == '*')
            {
                Console.WriteLine($"{N1} * {N2} = {N1 * N2} - " + ((N1 * N2) % 2 == 0 ? "even" : "odd"));
            }

            if (symbol == '/')
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }

                else
                {
                    Console.WriteLine($"{(double)N1} / {N2} = {(double)N1 / N2:f2}");
                }
            }

            if (symbol == '%')
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }

                else 
                {
                    Console.WriteLine($"{N1} % {N2} = {N1 % N2}");
                }
            }
        }
    }
}
