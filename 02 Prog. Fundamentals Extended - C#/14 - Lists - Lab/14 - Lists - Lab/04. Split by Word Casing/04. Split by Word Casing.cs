using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            var separators = new char[]
            {
                ',',';',':','.','!','(',')','"','\'','/','\\','[',']',' '
            };
            string[] words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            List<string> lowerCaseList = new List<string>();
            List<string> upperCaseList = new List<string>();
            List<string> mixedCaseList = new List<string>();
            foreach (var item in words)
            {
                var type = GetWordtype(item);
                if (type == Wordtype.Uppercase)
                {
                    upperCaseList.Add(item);
                }
                else if (type == Wordtype.Lowercase)
                {
                    lowerCaseList.Add(item);
                }
                else
                {
                    mixedCaseList.Add(item);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseList)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseList)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseList)}");
        }

        enum Wordtype { Uppercase, Mixedcase, Lowercase }

        static Wordtype GetWordtype(string word)
        {
            var upperLetters = 0;
            var lowerLetters = 0;
            foreach (var item in word)
            {
                if (char.IsUpper(item))
                {
                    upperLetters++;
                }
                else if (char.IsLower(item))
                {
                    lowerLetters++;
                }
            }
            if (upperLetters == word.Length)
            {
                return Wordtype.Uppercase;
            }
            if (lowerLetters == word.Length)
            {
                return Wordtype.Lowercase;
            }
            return Wordtype.Mixedcase;
        }
    }
}