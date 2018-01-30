using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Replace_a_tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var pattern = @"<a\s(\w.+?)>(\w.+?)<\/a>";

            var replaceUrl = new StringBuilder();

            while (input != "end")
            {
                var replacedLine = Regex.Replace(input, pattern, "[URL $1]$2[/URL]");
                //var replacedLine = Regex.Replace(html, pattern, m => $"[URL{m.Groups[1]}]{m.Groups[2]}[/URL]");

                replaceUrl.Append($"{replacedLine}{Environment.NewLine}");

                input = Console.ReadLine();
            }
            Console.WriteLine(replaceUrl);
        }
    }
}
