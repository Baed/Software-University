using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HTML_Contents
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = "index.html";
            File.AppendAllText(path, "<!DOCTYPE html>\r\n");
            File.AppendAllText(path, "<html>\r\n");
            File.AppendAllText(path, "<head>\r\n");

            String title = string.Empty;

            List<string[]> bodyContent = new List<string[]>();

            while (true)
            {
                string[] token = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(t => t.Trim())
                    .ToArray();

                if (token[0] == "exit")
                {
                    break;
                }
                else if (token[0] == "title")
                {
                    title = token[1];
                }
                else
                {
                    bodyContent.Add(token);
                }
            }
            File.AppendAllText(path, $"\t<title>{title}</title>\r\n");
            File.AppendAllText(path, $"</head>\r\n");
            File.AppendAllText(path, $"<body>\r\n");

            foreach (string[] tag in bodyContent)
            {
                File.AppendAllText(path, $"\t<{tag[0]}>{tag[1]}</{tag[0]}>\r\n");
            }

            File.AppendAllText(path, "</body>\r\n");
            File.AppendAllText(path, "</html>\r\n");
        }
    }
}
