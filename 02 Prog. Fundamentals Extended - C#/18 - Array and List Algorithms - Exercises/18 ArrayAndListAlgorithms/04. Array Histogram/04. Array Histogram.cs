using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Array_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            List<int> counts = new List<int>();

            string[] inputStrings = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < inputStrings.Length; i++)
            {
                if (!words.Contains(inputStrings[i]))
                {
                    words.Add(inputStrings[i]);
                    counts.Add(1);
                }
                else
                {
                    int index = words.IndexOf(inputStrings[i]);
                    counts[index]++;
                }
            }
            for (int fitstUnsortedElemnt = 0; fitstUnsortedElemnt < counts.Count - 1; fitstUnsortedElemnt++)
            {
                var i = fitstUnsortedElemnt + 1;
                var currentElement = counts[fitstUnsortedElemnt];

                while (i > 0)
                {
                    //swap metod
                    if (counts[i - 1] < counts[i])
                    {
                        int tempCount = counts[i];
                        counts[i] = counts[i - 1];
                        counts[i - 1] = tempCount;

                        string tempWords = words[i];
                        words[i] = words[i - 1];
                        words[i - 1] = tempWords;
                    }

                    i--;
                }
            }

            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine($"{words[i]} -> {counts[i]} times ({(double)counts[i] / (double)inputStrings.Length * 100:f2}%)");
            }
        }
    }
}
