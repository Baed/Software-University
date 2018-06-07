using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._03_GroupNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            List<List<int>> matrix = new List<List<int>>();

            matrix.Add(new List<int>());

            for (int i = 0; i < numbers.Length; i++)
            {
                matrix.Add(new List<int>());
            }

            int cnt = 10;

            for (int i = 0; i < 3; i++)
            {
                matrix[0].Add(cnt);
                cnt++;
            }                      
        }
    }
}
