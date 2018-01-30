using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._02_SumOfAllElementsOfMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputDim = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[][] matrix = new int[inputDim[0]][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            int maxSum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                // maxSum += matrix[i].Sum();
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    maxSum += matrix[i][j];
                }
            }
            Console.WriteLine(matrix.Length); // length of row
            Console.WriteLine(matrix[0].Length); // length of col
            Console.WriteLine(maxSum); // sum

        }
    }
}
