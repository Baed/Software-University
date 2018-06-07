using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GroupNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNum = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] sizesArr = new int[3]; // arr.Length == 3   --> index: 0, 1, 2;

            var caseOne = inputNum.Where(n => Math.Abs(n) % 3 == 0).ToArray();
            var caseTwo = inputNum.Where(n => Math.Abs(n) % 3 == 1).ToArray();
            var caseTree = inputNum.Where(n => Math.Abs(n) % 3 == 2).ToArray();

            Console.WriteLine(string.Join(" ", caseOne));
            Console.WriteLine(string.Join(" ", caseTwo));
            Console.WriteLine(string.Join(" ", caseTree));


        }
    }
}
