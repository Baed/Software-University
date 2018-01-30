using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().ToCharArray();

            foreach (var @char in input)
            {
                Console.Write($"\\u{((int)@char).ToString("X4")}".ToLower());
            }
            Console.WriteLine();

        }
    }
}
