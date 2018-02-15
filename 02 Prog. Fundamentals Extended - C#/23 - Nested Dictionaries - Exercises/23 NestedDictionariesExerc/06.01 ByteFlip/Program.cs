using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _06._01_ByteFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .Where(a => a.Length == 2)
                .Reverse()
                .ToList();

            for (int i = 0; i < input.Count; i++)
            {
                string reversted = new string(input[i].ToCharArray().Reverse().ToArray());
                input[i] = reversted;
            }

            foreach (var item in input)
            {
                int value = Convert.ToInt32(item, 16);

                Console.Write((char)value);
            }

        }
    }
}
