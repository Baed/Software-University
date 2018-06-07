using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Target_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] matrix = GetMatrix();
            GetShotOnSnakeMatrix(matrix);
         
            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join("", item));
            }
            //  Console.WriteLine(string.Join(Environment.NewLine, matrix.Select(r => string.Join(string.Empty, r))));

        }

        private static void GetShotOnSnakeMatrix(char[][] matrix)
        {
            var shotTokens = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rowInpact = shotTokens[0];
            var colInpact = shotTokens[1];
            var radius = shotTokens[2];

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (IsCellShooted(i, j, rowInpact, colInpact, radius))
                    {
                        matrix[i][j] = ' ';
                    }
                }
            }

            for (int j = 0; j < matrix[0].Length; j++)
            {
                for (int i = matrix.Length - 1; i > 0; i--)
                {
                    if (matrix[i][j] == ' ' && matrix[i - 1][j] != ' ')
                    {
                        CellsFallsDown(matrix, i, j);
                    }
                }
            }
        }

        private static void CellsFallsDown(char[][] matrix, int row, int col)
        {
            while (row < matrix.Length)
            {
                if (matrix[row][col] == ' ')
                {
                    var temp = matrix[row - 1][col];
                    matrix[row - 1][col] = matrix[row][col];
                    matrix[row][col] = temp;
                    row++;
                }
                else
                {
                    return;
                }
            }
        }

        private static bool IsCellShooted(int i, int j, int rowInpact, int colInpact, int radius)
        {
            var distance = Math.Sqrt((i - rowInpact) * (i - rowInpact) + (j - colInpact) * (j - colInpact));
            return distance <= radius;
        }

        private static char[][] GetMatrix()
        {
            var dimentions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrix = new char[dimentions[0]][]
                .Select(row => row = new char[dimentions[1]])
                .ToArray();

            var input = new Queue<char>(Console.ReadLine().ToCharArray());

            // var matrix = new char[dimentions[0]][];

            for (int i = matrix.Length - 1; i >= 0; i--)
            {
                //    matrix[i] = new char[dimentions[1]];
                for (int j = matrix[i].Length - 1; j >= 0; j--)   // for <-- direction
                {
                    matrix[i][j] = input.Dequeue();
                    input.Enqueue(matrix[i][j]);
                }

                i--;
                if (i < 0)
                {
                    break;
                }

                for (int j = 0; j < matrix[i].Length; j++) // for --> direction
                {
                    matrix[i][j] = input.Dequeue();
                    input.Enqueue(matrix[i][j]);
                }
            }
            return matrix;
        }

    }
}
