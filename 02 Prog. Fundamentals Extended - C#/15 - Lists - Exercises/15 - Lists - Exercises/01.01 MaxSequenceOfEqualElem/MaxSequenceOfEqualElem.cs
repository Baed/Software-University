using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._01_MaxSequenceOfEqualElem
{
    class MaxSequenceOfEqualElem
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> resultList = new List<int>();

            int cnt = 0;
            int startIndex = 0;
            int maxSequenseIndex = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    cnt++;

                    if (cnt > maxSequenseIndex)
                    {
                        maxSequenseIndex = cnt;
                        startIndex = i - cnt;
                    }
                }
                 
                else
                {
                    cnt = 0;                   
                }
            }

            for (int i = startIndex; i <= startIndex + maxSequenseIndex; i++)
            {
                resultList.Add(numbers[startIndex]);
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
