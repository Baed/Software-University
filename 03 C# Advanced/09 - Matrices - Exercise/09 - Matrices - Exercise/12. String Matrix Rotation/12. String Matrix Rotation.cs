using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.String_Matrix_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotate = GetRotateDegree();
            char[][] matrix = GetMatrix();
            switch (rotate)
            {
                case 0: PrintMatrix0(matrix);  break;
                case 90: PrintMatrix90(matrix); break;
                case 180: PrintMatrix180(matrix); break;
                case 270: PrintMatrix270(matrix); break;
            }
        }

        private static void PrintMatrix270(char[][] matrix)
        {
            for (int col = matrix[0].Length - 1; col >= 0; col--)
            {
                for (int row = 0; row < matrix.Length; row++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }
        }

        private static void PrintMatrix90(char[][] matrix)
        {
            for (int col = 0; col < matrix[0].Length; col++)
            {
                for (int row = matrix.Length - 1; row >= 0; row--)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }
        }

        private static void PrintMatrix180(char[][] matrix)
        {
            for (int i = matrix.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(string.Join("", matrix[i].Reverse()));
            }
        }

        private static void PrintMatrix0(char[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static int GetRotateDegree()
        {
            string input = Console.ReadLine().Trim();
            int degree = int.Parse(input.Substring("Rotate(".Length, input.Length - 1 - "Rotate(".Length));

            degree %= 360;

            while (degree < 0)
            {
                degree += 360;
            }
            return degree;
        }

        private static char[][] GetMatrix()
        {
            var textList = new List<string>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                textList.Add(input);
                input = Console.ReadLine();
            }

            var row = textList.Count();
            var col = textList.Select(t => t.Count()).Max();

            var matrix = new char[row][];

            for (int i = 0; i < matrix.Length; i++)
            {
                var builder = new StringBuilder(textList[i]);
                builder.Append(new string(' ', col - textList[i].Length));
                matrix[i] = builder.ToString().ToCharArray();
            }
            return matrix;
        }
    }
}
