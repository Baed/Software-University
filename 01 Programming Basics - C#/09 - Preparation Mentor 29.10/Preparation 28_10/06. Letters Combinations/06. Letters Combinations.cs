using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char except = char.Parse(Console.ReadLine());

            var ctr = 0;

            for (char i = start; i <= end; i++)
            {
                for (char j = start; j <= end; j++)
                {
                    for (char k = start; k <= end; k++)
                    {
                        if (i != except && j != except && k != except)
                        {
                            Console.Write($"{i}{j}{k} ");
                            ctr++;
                        }                       
                    }
                }
            }
            Console.WriteLine($"{ctr}");
        }
    }
}
