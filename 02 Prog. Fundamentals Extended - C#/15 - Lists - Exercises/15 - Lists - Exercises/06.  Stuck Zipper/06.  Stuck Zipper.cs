using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stuck_Zipper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int minLength = FindMinLength(firstList, secondList); // 2 metoda

            List<int> firstFiltredList = new List<int>();
            List<int> secondFiltredList = new List<int>();
            for (int i = 0; i < firstList.Count; i++)
            {
                if (FindNumberLength(firstList[i]) <= minLength)
                {
                    firstFiltredList.Add(firstList[i]);
                }
            }
            for (int i = 0; i < secondList.Count; i++)
            {
                if (FindNumberLength(secondList[i]) <= minLength)
                {
                    secondFiltredList.Add(secondList[i]);
                }
            }

            List<int> result = new List<int>();

            for (int i = 0; i < Math.Max(firstFiltredList.Count, secondFiltredList.Count); i++)
            {
                if (i < secondFiltredList.Count)
                {
                    result.Add(secondFiltredList[i]);
                }
                if (i < firstFiltredList.Count)
                {
                    result.Add(firstFiltredList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }

        private static int FindMinLength(List<int> firstList, List<int> secondList)
        {
            int minLength = int.MaxValue;
            for (int i = 0; i < firstList.Count; i++)
            {
                if (minLength > FindNumberLength(firstList[i]))
                {
                    minLength = FindNumberLength(firstList[i]);
                }
            }
            for (int i = 0; i < secondList.Count; i++)
            {
                if (minLength > FindNumberLength(secondList[i]))
                {
                    minLength = FindNumberLength(secondList[i]);
                }
            }
            return minLength;
        }

        private static int FindNumberLength(int number)
        {
            int digitCount = 0;
            number = Math.Abs(number);
            while (number > 0)
            {
                digitCount++;
                number /= 10; //241 / 10 = 21 / 10 = 2 / 10 = 0 -- > cnt = 3
            }
            return digitCount;
        }
    }
}
