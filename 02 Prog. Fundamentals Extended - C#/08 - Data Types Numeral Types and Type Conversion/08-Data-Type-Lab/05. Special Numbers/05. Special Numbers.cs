using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCnt = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputCnt; ++i)
            {
                int num = i;
                int startingNum = num;
                int sum = 0;

                while (num > 0) //123 = 1 + 2 + 3
                {
                    int currentDigit = num % 10; // zaradi subirane na otdelnite chisla
                    num = num / 10;
                    sum += currentDigit;
                }

                bool result = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{startingNum} -> {result}");
            }          
        }
    }
}
