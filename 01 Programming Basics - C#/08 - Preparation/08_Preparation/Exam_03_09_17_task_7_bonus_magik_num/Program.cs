using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_03_09_17_task_7_bonus_magik_num
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int ones = 1; ones <= 9; ones++)
            {
                for (int twoes = 1; twoes <= 9; twoes++)
                {
                    for (int trees = 1; trees <= 9; trees++)
                    {
                        for (int fors = 1; fors <= 9; fors++)
                        {
                            for (int fives = 1; fives <= 9; fives++)
                            {
                                for (int sixes = 1; sixes <= 9; sixes++)
                                {
                                    if (ones * twoes * trees * fors * fives * sixes == n)
                                    {
                                        Console.Write($"{ones}{twoes}{trees}{fors}{fives}{sixes} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
