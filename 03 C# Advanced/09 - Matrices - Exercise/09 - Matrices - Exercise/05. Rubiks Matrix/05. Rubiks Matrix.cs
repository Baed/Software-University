using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rubiks_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = GetMatrix();
            ReadCommands(matrix);
            PrintResult(matrix);
        }

        private static void PrintResult(int[][] matrix)
        {
            var element = 1;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == element)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int row = 0; row < matrix.Length; row++)
                        {
                            for (int col = 0; col < matrix[row].Length; col++)
                            {
                                if (matrix[row][col] == element)
                                {
                                    var currentElement = matrix[i][j];
                                    matrix[i][j] = element;
                                    matrix[row][col] = currentElement;
                                    Console.WriteLine($"Swap ({i}, {j}) with ({row}, {col})");
                                    break;
                                }
                            }
                        }
                    }
                    element++;
                }
            }
        }

        private static void ReadCommands(int[][] matrix)
        {

            int commands = int.Parse(Console.ReadLine());
            while (commands > 0)
            {
                var tokens = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var indexRowCol = int.Parse(tokens[0]);
                var direction = tokens[1];
                var moves = int.Parse(tokens[2]);

                RotateMatrix(matrix, indexRowCol, direction, moves);

                commands--;
            }
        }

        private static void RotateMatrix(int[][] matrix, int indexRowCol, string direction, int moves)
        {
            switch (direction.ToLower())
            {
                case "up":
                    RotateColumn(matrix, indexRowCol, moves);
                    break;
                case "down":
                    RotateColumn(matrix, indexRowCol, (matrix.Length - moves % matrix.Length));
                    break;
                case "left":
                    RotateRow(matrix, indexRowCol, moves);
                    break;
                case "right":
                    RotateRow(matrix, indexRowCol, (matrix[0].Length - moves % matrix[0].Length));
                    break;
            }
        }

        private static void RotateRow(int[][] matrix, int indexRowCol, int moves)
        {
            int[] temp = new int[matrix[0].Length];

            for (int col = 0; col < matrix[0].Length; col++)
            {
                temp[col] = matrix[indexRowCol][(col + moves) % matrix[0].Length];
            }
            matrix[indexRowCol] = temp;
        }

        private static void RotateColumn(int[][] matrix, int indexRowCol, int moves)
        {
            int[] temp = new int[matrix.Length];
            for (int i = 0; i < matrix.Length; i++)
            {
                temp[i] = matrix[(i + moves) % matrix.Length][indexRowCol];
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i][indexRowCol] = temp[i];
            }
        }

        private static int[][] GetMatrix()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //alternative, see to tick roll !
            //var matrix = new int[input[0]][].Select(r => r = new int[input[1]]).ToArray();

            int inputValueOfMatrix = 1;
            int[][] matrix = new int[input[0]][]; // tick   

            for (int i = 0; i < matrix.Length; i++)    // input[0]
            {
                matrix[i] = new int[input[1]]; // tick

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = inputValueOfMatrix;
                    inputValueOfMatrix++;
                }
            }
            return matrix;
        }
    }
}
