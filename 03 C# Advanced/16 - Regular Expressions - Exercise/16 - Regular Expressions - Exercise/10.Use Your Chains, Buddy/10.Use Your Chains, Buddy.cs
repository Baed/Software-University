using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var regex = new Regex(@"<p>(.*?)<\/p>");
            var matches = regex.Matches(input);

            string extract = "";

            foreach (Match match in matches)
            {
                extract += match.Groups[1].ToString();
            }

            var replaced = Regex.Replace(extract, @"[^a-z0-9]", " ");
            replaced = Regex.Replace(replaced, @"\s+|\n+", " ");

            var sb = new StringBuilder();

            foreach (var @char in replaced)
            {
                if (@char >= 'a' && @char <= 'm')
                {
                    sb.Append((char)(@char + 13));
                }
                else if (@char >= 'n' && @char <= 'z')
                {
                    sb.Append((char)(@char - 13));
                }
                else
                {
                    sb.Append(@char);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
