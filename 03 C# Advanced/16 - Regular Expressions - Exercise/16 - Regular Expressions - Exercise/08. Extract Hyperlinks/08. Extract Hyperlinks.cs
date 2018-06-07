using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Extract_Hyperlinks
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var pattern = @"<a[\s\S]*?\s+href\s*=\s*([""'])?([\s\S]*?)(?:>|class|\1)[\s\S]*?<\/a>";

            var regex = new Regex(pattern);

            var sb = new StringBuilder();

            while (input != "END")
            {
                sb.Append(input);

                input = Console.ReadLine();
            }

            var matches = regex.Matches(sb.ToString());

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value);
            }
        }
    }
}
