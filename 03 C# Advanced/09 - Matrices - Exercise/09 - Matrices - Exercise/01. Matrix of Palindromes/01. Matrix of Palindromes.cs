using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string[][] matrix = new string[input[0]][];

            for (int k = 0; k < input[0]; k++)
            {
                matrix[k] = new string[input[1]];

                for (int z = 0; z < input[1]; z++)
                {
                    var firstAndLastLetter = (char)('a' + k);
                    var middleLetter = (char)('a' + k + z);

                    var palindrome = new StringBuilder();
                    palindrome
                        .Append($"{firstAndLastLetter}{middleLetter}{firstAndLastLetter}");

                    matrix[k][z] = palindrome.ToString();
                }
            }

            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
