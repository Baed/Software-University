using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Latin_L
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int a = 0; a < n; a++) // (char a = 'a'; a < 'a' + n; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        Console.Write($"{(char)(a + 'a')}{(char)(b + 'a')}{(char)(c + 'a')} ");
                    }
                }
            }
        }
    }
}
