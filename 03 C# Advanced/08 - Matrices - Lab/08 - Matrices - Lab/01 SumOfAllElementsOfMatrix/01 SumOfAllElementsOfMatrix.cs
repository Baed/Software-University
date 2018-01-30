using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SumOfAllElementsOfMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputDim = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[inputDim[0], inputDim[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var inputRows = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = inputRows[j];
                }
            }

            int maxSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    maxSum += matrix[i, j];
                }
            }

            Console.WriteLine(matrix.GetLength(0)); // length of row
            Console.WriteLine(matrix.GetLength(1)); // length of col
            Console.WriteLine(maxSum); // sum
        }
    }
}
