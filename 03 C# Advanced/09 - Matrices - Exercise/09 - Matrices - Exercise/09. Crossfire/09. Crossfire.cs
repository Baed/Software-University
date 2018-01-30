using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Crossfire
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = GetMatrix();
            matrix = ReadCommand(matrix);
            PrintResult(matrix);
        }
        private static void PrintResult(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i].Where(col => col != -1)));
            }
        }
        private static int[][] ReadCommand(int[][] matrix)
        {
            string command = Console.ReadLine().Trim();
            while (command != "Nuke it from orbit")
            {
                var tokens = command
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var rowDestroy = tokens[0];
                var colDestroy = tokens[1];
                var radius = tokens[2];

                matrix = DestroyCells(matrix, rowDestroy, colDestroy, radius);
                command = Console.ReadLine().Trim();
            }
            return matrix;
        }
        private static int[][] DestroyCells(int[][] matrix, int rowDestroy, int colDestroy, int radius)
        {
            for (int row = rowDestroy - radius; row <= rowDestroy + radius; row++)
            {
                if (IsRange(row, colDestroy, matrix))
                {
                    matrix[row][colDestroy] = -1;
                }
            }
            for (int col = colDestroy - radius; col <= colDestroy + radius; col++)
            {
                if (IsRange(rowDestroy, col, matrix))
                {
                    matrix[rowDestroy][col] = -1;
                }
            }
            // remove destroyed cells
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] < 0) //
                    {
                        matrix[i] = matrix[i]
                            .Where(n => n > 0)
                            .ToArray();
                        break;
                    }
                }
                // remove empty rows, whitch have value -1
                if (matrix[i].Count() < 1)
                {
                    matrix = matrix
                        .Take(i)
                        .Concat(matrix.Skip(i + 1))
                        .ToArray();
                    i--;
                }
            }
            return matrix;
        }
        private static bool IsRange(int row, int col, int[][] matrix)
        {
            return row >= 0 && col >= 0 && row < matrix.Length && col < matrix[row].Length;
        }
        private static int[][] GetMatrix()
        {
            int[] dimentions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[][] matrix = new int[dimentions[0]][];

            int cnt = 1;
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[dimentions[1]];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = cnt;
                    cnt++;
                }
            }
            return matrix;
        }
    }
}
