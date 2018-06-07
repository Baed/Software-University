using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._01_SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            List<string> numbersList = Console.ReadLine().Split(' ').ToList();

            long sum = 0;

            foreach (string number in numbersList)
            {
                char[] reversedDigits = number.ToCharArray().Reverse().ToArray();
                //Array.Reverse(charArray);

                string digit = new string(reversedDigits);

                sum += int.Parse(digit);
            }

            // int sum = Console.ReadLine().Split().Select(e => new String(e.Reverse().ToArray())).Sum(e => int.Parse(e));

            Console.WriteLine(sum);
        }
    }
}
