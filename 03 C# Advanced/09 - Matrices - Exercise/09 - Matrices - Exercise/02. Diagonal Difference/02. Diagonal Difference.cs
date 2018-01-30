using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            var PrimaryDiagonal = 0;
            var SecondaryDiagonal = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                PrimaryDiagonal += matrix[i][i];
                SecondaryDiagonal += matrix[i][matrix.Length - 1 - i];
            }

            Console.WriteLine(Math.Abs(PrimaryDiagonal - SecondaryDiagonal));
        }
    }
}
