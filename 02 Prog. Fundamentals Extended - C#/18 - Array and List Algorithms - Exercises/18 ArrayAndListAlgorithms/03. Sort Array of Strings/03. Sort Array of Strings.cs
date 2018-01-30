using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sort_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            //List<string> input = Console.ReadLine().Split(' ').ToList();
            //input.Sort();

            for (int i = 0; i < input.Length; i++)
            {
                for (int index = 0; index < input.Length - 1; index++)
                {
                    string first = input[index];
                    string second = input[index + 1];

                    if (first.CompareTo(second) > 0)
                    {
                        input[index] = second;
                        input[index + 1] = first;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
