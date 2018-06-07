using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNum = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[][] matrix = new string[inputNum[0]][];

            for (int i = 0; i < inputNum[0]; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            var cnt = 0;
            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = 0; j < matrix[i].Length - 1; j++)
                {
                    var serchedChar = matrix[i][j];
                    if (serchedChar == matrix[i][j + 1] && serchedChar == matrix[i + 1][j] && serchedChar == matrix[i + 1][j + 1])
                    {
                        cnt++;
                    }
                }

            }
            Console.WriteLine(cnt);
        }
    }
}
