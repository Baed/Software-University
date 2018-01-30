using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Replace_a_tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex pattern = new Regex("<a(?<href> href=\"[^\"]+\")>");
            Regex pattern2 = new Regex(@"<\/a>");

            MatchCollection matchCollection = pattern.Matches(text);
            MatchCollection matchCollection2 = pattern2.Matches(text);

            Console.WriteLine("<ul>");
            Console.WriteLine("  " + "<li>");

            var cnt = 0;
            while (text != "end")
            {
                cnt++;

                if (cnt == 3)
                {
                    foreach (Match num in matchCollection)
                    {
                        Console.Write("    " + "[URL" + num.Groups["href"].Value);
                    }
                    foreach (Match num2 in matchCollection2)
                    {
                        Console.WriteLine(">SoftUni" + "[/URL]" + num2.Groups[1]);
                    }
                }

                
                text = Console.ReadLine();
            }


            Console.WriteLine("  " + "</li>");
            Console.WriteLine("</ul>");
        }
    }
}
