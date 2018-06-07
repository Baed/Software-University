using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Lego_Blocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputRows = int.Parse(Console.ReadLine());
            int[][] firstMatrix = GetMatrix(inputRows);
            int[][] secondMatrix = GetMatrix(inputRows).Select(row => row.Reverse().ToArray()).ToArray();
            PrintResult(firstMatrix, secondMatrix);
        }
        private static void PrintResult(int[][] firstMatrix, int[][] secondMatrix)
        {
            if (IsRectangularMatrixes(firstMatrix, secondMatrix))
            {
                for (int i = 0; i < firstMatrix.Length; i++)
                {
                    Console.WriteLine($"[{string.Join(", ", firstMatrix[i].Concat(secondMatrix[i]))}]");
                }
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {GetCellsCount(firstMatrix, secondMatrix)}");
            }
        }

        private static int GetCellsCount(int[][] firstMatrix, int[][] secondMatrix)
        {
            var numberOfCells = 0;

            for (int i = 0; i < firstMatrix.Length; i++)
            {
                numberOfCells += firstMatrix[i].Length + secondMatrix[i].Length;
            }

            return numberOfCells;
        }

        private static bool IsRectangularMatrixes(int[][] firstMatrix, int[][] secondMatrix)
        {
            for (int i = 1; i < firstMatrix.Length; i++)
            {
                if (firstMatrix[i].Length + secondMatrix[i].Length !=
                    firstMatrix[i - 1].Length + secondMatrix[i - 1].Length)
                {
                    return false;
                }
            }
            return true;
        }

        private static int[][] GetMatrix(int inputRows)
        {
            int[][] matrix = new int[inputRows][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
            return matrix;
        }
    }
}
