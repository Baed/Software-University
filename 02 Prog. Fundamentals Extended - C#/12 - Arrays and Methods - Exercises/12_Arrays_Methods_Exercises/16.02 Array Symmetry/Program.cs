using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._02_Array_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            string[] reversed = new string[words.Length];
            bool isSymmetric = true;

            for (int i = 0; i < words.Length; i++)
            {
                reversed[i] = words[i];
            }
            Array.Reverse(reversed);
            for (int i = 0; i < words.Length; i++)
            {
                if (reversed[i] != words[i])
                {
                    isSymmetric = false;
                }
            }
            Console.WriteLine(isSymmetric == true ? "Yes" : "No");
        }
    }
}
