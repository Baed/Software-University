using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_03_09_17_task_6_profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneCount = int.Parse(Console.ReadLine());
            int twoCount = int.Parse(Console.ReadLine());
            int fiveount = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int one = 0; one <= oneCount; one++)
            {
                for (int two = 0; two <= twoCount; two++)
                {
                    for (int fives = 0; fives <= fiveount; fives++)
                    {
                        if (one + two * 2 + fives * 5 == sum)
                        {
                            Console.WriteLine("{0} * 1 lv. + {1} * 2 lv. + {2} * 5 lv. = {3} lv.", one , two, fives, sum);
                        }
                    }
                }
            }
        }
    }
}
