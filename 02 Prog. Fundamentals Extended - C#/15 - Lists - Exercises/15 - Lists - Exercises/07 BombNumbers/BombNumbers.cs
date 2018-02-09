using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> sequenceArr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string[] specialNumbers = Console.ReadLine().Split(' ');

            int index = int.Parse(specialNumbers[0]);
            int power = int.Parse(specialNumbers[1]);

            for (int i = 0; i < sequenceArr.Count; i++)
            {
                if (sequenceArr[i] == index)
                {
                    int left = Math.Max(i - power, 0);
                    int right = Math.Min(i + power, sequenceArr.Count - 1);

                    int length = right - left + 1;

                    sequenceArr.RemoveRange(left, length);
                    i--;
                }
            }
            Console.WriteLine(sequenceArr.Sum());
        }
    }
}
