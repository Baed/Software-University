using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var firstNum = new Stack<char>(Console.ReadLine().TrimStart('0'));
            byte secondNum = byte.Parse(Console.ReadLine().TrimStart('0'));

            var result = new StringBuilder();
            int sum = 0;

            while (firstNum.Count != 0 && secondNum >= 0 && secondNum <= 9)
            {
                sum /= 10;

                if (firstNum.Count != 0)
                {
                    sum += int.Parse(firstNum.Pop().ToString()) * secondNum;
                }

                var digit = sum % 10;

                result.Insert(0, digit);

            }

                result.Insert(0, sum / 10);
            
            Console.WriteLine(result.ToString().TrimStart('0'));

        }
    }
}
