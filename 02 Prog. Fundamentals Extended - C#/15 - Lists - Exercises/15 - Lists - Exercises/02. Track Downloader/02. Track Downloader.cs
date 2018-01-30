using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Track_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] blackListWords = Console.ReadLine().Split(' ');
            List<string> resultList = new List<string>();
            string fileNames = "";
            while (!fileNames.Equals("end"))
            {
                bool isContains = false;
                foreach (var words in blackListWords)
                {
                    if (fileNames.Contains(words))
                    {
                        isContains = true;
                    }
                }
                if (!isContains)
                {
                    resultList.Add(fileNames);
                }
                fileNames = Console.ReadLine();
            }
            //resultList = resultList.OrderBy(x => x).ToList();
            resultList.Sort();
            Console.WriteLine(string.Join(Environment.NewLine, resultList));
        }
    }
}
