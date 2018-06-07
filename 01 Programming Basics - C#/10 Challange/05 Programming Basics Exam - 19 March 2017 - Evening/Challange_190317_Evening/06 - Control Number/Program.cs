using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int N  = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int control_num = int.Parse(Console.ReadLine());

            var moves = 0;
            var sum = 0;

            for (int i = 1; i <= N; i++)
            {
                for (int j = M; j >= 1; j--)
                {
                    sum += i * 2 + j * 3;
                    moves++;

                    if (sum >= control_num)
                    {
                        Console.WriteLine($"{moves} moves");
                        Console.WriteLine($"Score: {sum} >= {control_num}");
                        return;
                    }                    
                }
            }
            Console.WriteLine($"{moves} moves");
        }
    }
}
