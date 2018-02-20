using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._01_SumBigNumbers
{
    class SumBigNumbers
    {
        static void Main(string[] args)
        {
            {
                string firstNum = Console.ReadLine().TrimStart('0');
                string secondNum = Console.ReadLine().TrimStart('0');

                int pad = Math.Max(firstNum.Length, secondNum.Length);

                if (firstNum.Length != secondNum.Length)
                {
                    firstNum = firstNum.PadLeft(pad, '0');
                    secondNum = secondNum.PadLeft(pad, '0');
                }

                int inMind = 0;
                int remainder = 0;

                StringBuilder sb = new StringBuilder();

                for (int i = firstNum.Length - 1; i >= 0; i--)
                {
                    int sum = int.Parse(firstNum[i].ToString()) + int.Parse(secondNum[i].ToString()) + inMind;

                    inMind = sum / 10;
                    remainder = sum % 10;
                    sb.Insert(0, remainder.ToString());

                    if (i == 0 && inMind != 0)
                    {
                        sb.Insert(0, inMind.ToString());
                    }
                }

                Console.WriteLine(sb);
            }
        }
    }
}
