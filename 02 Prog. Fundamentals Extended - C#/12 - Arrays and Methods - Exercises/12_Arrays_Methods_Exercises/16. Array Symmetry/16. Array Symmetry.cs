using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Array_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            bool isSymmetric = true;
            for (int i = 1; i < input.Length; i++)
            {
                string currentInput = input[i];
                Array.Reverse(input);
                if (currentInput != input[i])
                {
                    isSymmetric = false;
                }
            }
            Console.WriteLine(isSymmetric == true ? "Yes" : "No");
        }
    }
}
