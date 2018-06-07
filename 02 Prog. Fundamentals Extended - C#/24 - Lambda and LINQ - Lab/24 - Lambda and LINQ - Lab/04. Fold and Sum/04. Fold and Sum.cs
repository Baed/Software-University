using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = initialNumbers.Length / 4;

            List<int> leftPart = initialNumbers.Take(k).Reverse().ToList();
            List<int> rightPart = initialNumbers.Reverse().Take(k).ToList(); // reverse !!!

            //Console.WriteLine(string.Join(" ", leftPart));
            //Console.WriteLine(string.Join(" ", rightPart));

            int[] downArr = initialNumbers.Skip(k).Take(2 * k).ToArray();

            //Console.WriteLine(string.Join(" ", downArr));

            int[] upperPart = leftPart.Concat(rightPart).ToArray();

            //Console.WriteLine(string.Join(" ", upperPart));

            for (int i = 0; i < downArr.Length; i++)
            {
                downArr[i] += upperPart[i];
            }

            Console.WriteLine(string.Join(" ", downArr));
            /*
            var sumArr = upperPart.Select((x, index) => x + downArr[index]);

            Console.WriteLine(string.Join(" ", sumArr));
            */
        }
    }
}
