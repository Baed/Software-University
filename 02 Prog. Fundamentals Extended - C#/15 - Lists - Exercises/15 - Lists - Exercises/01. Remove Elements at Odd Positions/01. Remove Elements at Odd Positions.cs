using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Elements_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            List<string> result = new List<string>();

                for (int i = 1; i < input.Count; i++)
                {
                    if (i % 2 != 0)
                    {
                        result.Add(input[i]);
                    }
                }
            Console.WriteLine(string.Join("", result));
        }
    }
}
