using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Two_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magic_num = int.Parse(Console.ReadLine());

            var combination_num = 0;

            for (int i = start; i >= end; i--)
            {
                for (int j = start; j >= end; j--)
                {
                    combination_num++;

                    if (i + j == magic_num)
                    {
                        Console.WriteLine($"Combination N:{combination_num} ({i} + {j} = {i + j})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{combination_num} combinations - neither equals {magic_num}");
        }
    }
}
