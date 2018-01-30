using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[][] matrix = new int[matrixSize[0]][];

            for (int i = 0; i < matrixSize[0]; i++)
            {
                matrix[i] = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            }

            int resultSum = int.MinValue;
            int[] resultStartIndex = new int[2];

            for (int i = 0; i < matrix.Length - 2; i++)
            {
                for (int j = 0; j < matrix[i].Length - 2; j++)
                {
                    int currentSum = matrix[i][j] + matrix[i][j + 1] + matrix[i][j + 2]
                        + matrix[i + 1][j] + matrix[i + 1][j + 1] + matrix[i + 1][j + 2]
                        + matrix[i + 2][j] + matrix[i + 2][j + 1] + matrix[i + 2][j + 2];

                    if (currentSum > resultSum)
                    {
                        resultSum = currentSum;
                        resultStartIndex[0] = i;
                        resultStartIndex[1] = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {resultSum}");

            Console.WriteLine(
                string.Join(Environment.NewLine, matrix
                .Skip(resultStartIndex[0])
                .Take(3)
                .Select(
                row => string.Join(" ", 
                row.Skip(resultStartIndex[1])
                .Take(3)))
                ));

        }
    }
}
