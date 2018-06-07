using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Parse_Tags
{
    class Program
    {
        static void Main(string[] args)
        {
            // We are living in a <upcase>yellow submarine</upcase >.
            // We don't have <upcase>anything</upcase> else.

            string text = Console.ReadLine();

            string openTag = "<upcase>";
            string closeTag = "</upcase>";
            int indexOfOpenTag = text.IndexOf(openTag); //(19)

            while (indexOfOpenTag != -1)
            {
                // Skip the first character with a startIndex of indexOfOpenTag.
                int indexOfEndText = text.IndexOf(closeTag, indexOfOpenTag); //(43 , 19)
                int indexOfCloseTagEnd = indexOfEndText + closeTag.Length;

                if (indexOfEndText < 0)
                {
                    break;
                }

                int indexOfStartText = indexOfOpenTag + openTag.Length;

                string textToReplace = text.Substring(indexOfOpenTag, indexOfCloseTagEnd - indexOfOpenTag);
                //text.Substring(19, 43 - 19) --> .Substring(startIndex, Length)
                string replacedText = text.Substring(indexOfStartText, indexOfEndText - indexOfStartText).ToUpper();

                text = text.Replace(textToReplace, replacedText);

                indexOfOpenTag = text.IndexOf(openTag);
            }
            Console.WriteLine(text);
        }
    }
}
