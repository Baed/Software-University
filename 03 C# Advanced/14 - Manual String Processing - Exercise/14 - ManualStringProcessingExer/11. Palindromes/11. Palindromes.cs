using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Palindromes
{
    class Program
    {
        private static readonly char[] separator = new[] { ' ', '!', '?', ',', '.', '-' };

        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);

            GetPalindromes(input);

            Console.WriteLine($"[{string.Join(", ", GetPalindromes(input))}]");
        }

        private static SortedSet<string> GetPalindromes(string[] input)
        {
            var palindromes = new SortedSet<string>();

            foreach (var word in input)
            {
                bool isPalindrome = true;

                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i] != word[word.Length - 1 - i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                if (isPalindrome)
                {
                    palindromes.Add(word);
                }
            }
            return palindromes;
        }
    }
}
