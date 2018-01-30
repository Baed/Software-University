using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Nilapdromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            while (line != "end")
            {
                string nimapdrome = ReturnNilapdrome(line);

                if (nimapdrome != "")
                {
                    Console.WriteLine(nimapdrome);
                }

                line = Console.ReadLine();
            }
        }

        private static string ReturnNilapdrome(string line)
        {
            int middleIndex = line.Length / 2;
            string border = "";
            int leftIndex = 0;

            for (int i = middleIndex + 1; i < line.Length; i++)
            {
                if (line[leftIndex] == line[i])
                {
                    border += line[i];
                    leftIndex++;
                }
                else
                {
                    border = "";
                    leftIndex = 0;

                    if (line[i] == line[leftIndex])
                    {
                        border += line[i];
                        leftIndex++;
                    }
                }
            }

            if (border != "")
            {
                int leftIndexMiddle = line.IndexOf(border);
                int rightIndexMiddle = line.LastIndexOf(border);

                string middle = line.Substring(leftIndexMiddle + border.Length,
                    rightIndexMiddle - leftIndexMiddle - border.Length);

                if (middle != "")
                {
                    return middle + border + middle;
                }
            }
            return "";
        }
    }
}
