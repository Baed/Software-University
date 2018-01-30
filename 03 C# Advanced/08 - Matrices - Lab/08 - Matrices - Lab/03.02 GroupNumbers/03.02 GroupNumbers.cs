using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._02_GroupNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] sizes = new int[3];

            foreach (var number in numbers)
            {
                int reminder = Math.Abs(number % 3);
                sizes[reminder]++;
            }

            int[][] matrix = new int[3][]
            {
                 new int[sizes[0]],
                 new int[sizes[1]],
                 new int[sizes[2]]
            };

            int[] offsets = new int[3];

            foreach (var number in numbers)
            {
                int reminder = Math.Abs(number % 3);
                int index = offsets[reminder];
                matrix[reminder][index] = number;
                offsets[reminder]++;
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
