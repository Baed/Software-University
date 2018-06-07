using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var rangeNum = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderBy(n => n)
                .ToList();

            var command = Console.ReadLine().ToLower();

            var sortedNumbers = GetSortedNumbers(rangeNum, command);

            PrintResult(sortedNumbers);
        }

        private static void PrintResult(List<int> sortedNumbers)
        {
            Action<List<int>> printer = 
                nums => Console.WriteLine(string.Join(" ", nums));

            if (sortedNumbers.Count != 0)
            {
                printer(sortedNumbers);
            }
        }

        private static List<int> GetSortedNumbers(List<int> rangeNum, string command)
        {
            Predicate<int> isEven = nums => nums % 2 == 0;

            var sortedNumbers = new List<int>();

            //IEnumerable<int> num = Enumerable.Range(rangeNum[0], rangeNum[1] - rangeNum[0] + 1);

            for (int i = rangeNum[0]; i <= rangeNum[1]; i++)
            {
                if (isEven(i) && command == "even"
                    || !isEven(i) && command == "odd")
                {
                    sortedNumbers.Add(i);
                }
            }
            return sortedNumbers;
        }
    }
}
