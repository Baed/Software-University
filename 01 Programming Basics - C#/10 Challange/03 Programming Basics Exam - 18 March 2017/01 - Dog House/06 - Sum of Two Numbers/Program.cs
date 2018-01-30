using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            var sum = 0;
            
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    sum++;
                    if (i + j == magic)
                    {
                        Console.WriteLine(
                            "Combination N:{0} ({1} + {2} = {3})",
                            sum, i, j, i + j);
                        return; // break - pokazva 4-te kombinacii
                    }
                }
            }
            Console.WriteLine("{0} combinations - neither equals {1}", sum, magic);
        }
    }
}
