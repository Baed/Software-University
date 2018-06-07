using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Sentence_Extractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            string input = Console.ReadLine();

            var pattern = @"(?=^|\s).*?[.!?]";

            var regex = new Regex(pattern);

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                var regexKeyWord = new Regex($@"\b{keyWord}\b");

                if (regexKeyWord.IsMatch(match.Value))
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
