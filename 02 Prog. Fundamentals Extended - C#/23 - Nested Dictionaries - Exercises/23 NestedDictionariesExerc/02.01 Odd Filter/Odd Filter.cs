using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._01_Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .ToList();

            var averageListOfNums = numList.Average();

            numList = numList.Select(x => x = x > averageListOfNums ? ++x : --x)
                .ToList();

            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
