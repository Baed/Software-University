using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._03_DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int count = 0;
            var firstAndLast = "";

            for (int i = 1; i <= 4; i++)
            {
                for (int k = 1; k <= 4; k++)
                {
                    for (int j = 1; j <= 4; j++)
                    {
                        count++;
                        if ((i + k + j) >= sum)
                        {
                            firstAndLast = "0";                        
                        }
                        else
                        {
                            firstAndLast = "X";                            
                        }
                     Console.Write($"{firstAndLast}{("" + i + k + j).Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T')}{firstAndLast} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
