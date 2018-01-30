using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputDim = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[][] matrix = new int[inputDim[0]][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            var matrixIndexRow = 0;
            var matrixIndexCol = 0;
            var MaxSum = int.MinValue;

            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = 0; j < matrix[i].Length - 1; j++)
                {
                    var currentSum = 
                        matrix[i][j]
                        + matrix[i][j + 1]
                        + matrix[i + 1][j]
                        + matrix[i + 1][j + 1];

                    if (MaxSum < currentSum)
                    {
                        MaxSum = currentSum;
                        matrixIndexRow = i;
                        matrixIndexCol = j;
                    }
                }
            }
            Console.WriteLine($"{matrix[matrixIndexRow][matrixIndexCol]} {matrix[matrixIndexRow][matrixIndexCol + 1]}");
            Console.WriteLine($"{matrix[matrixIndexRow + 1][matrixIndexCol]} {matrix[matrixIndexRow + 1][matrixIndexCol + 1]}");
            Console.WriteLine(MaxSum);
        }
    }
}
