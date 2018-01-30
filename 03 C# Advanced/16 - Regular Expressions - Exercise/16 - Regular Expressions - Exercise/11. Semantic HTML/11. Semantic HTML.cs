using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _11.Semantic_HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            while (line != "END")
            {

                var openingMatch = Regex.Match(line, "<(div)([^>]+)(?:id|class)\\s*=\\s*\"(.*?)\"(.*?)>");
                var closedMatch = Regex.Match(line, @"<\/div>\s*<!--\s*(.*?)\s*-->");

                if (openingMatch.Success)
                {
                    line = Regex.Replace(line, "<(div)([^>]+)(?:id|class)\\s*=\\s*\"(.*?)\"(.*?)>", @"$3 $2 $4").Trim();
                    line = "<" + Regex.Replace(line, @"\s+", " ") + ">";
                }
                else if (closedMatch.Success)
                {
                    line = "</" + closedMatch.Groups[1] + ">";
                }
                Console.WriteLine(line);
                line = Console.ReadLine();
            }
        }
    }
}
