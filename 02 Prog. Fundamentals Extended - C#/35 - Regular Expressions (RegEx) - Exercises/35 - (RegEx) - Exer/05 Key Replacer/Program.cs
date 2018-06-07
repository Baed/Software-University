using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05_Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyInput = Console.ReadLine();

            string textInput = Console.ReadLine();

            string pattern = @"([\w+]*)(?:\<|\||\\)(?:.+)(?:\<|\||\\)(\w+)";

            Regex regex = new Regex(pattern);

            var match = regex.Match(keyInput);

            string start = match.Groups[1].Value;
            string end = match.Groups[2].Value;

            string wordPattern = $@"{start}(.*?){end}";

            MatchCollection matches = Regex.Matches(textInput, wordPattern);

            if (matches.Count > 0)
            {
                foreach (Match item in matches)
                {
                    Console.Write(item.Groups[1].Value);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
