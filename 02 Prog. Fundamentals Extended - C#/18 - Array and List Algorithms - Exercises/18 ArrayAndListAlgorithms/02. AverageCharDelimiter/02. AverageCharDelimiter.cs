using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AverageCharDelimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(' ').ToList();
            double totalWordSum = 0;
            double counterCharacters = 0;
            for (int i = 0; i < elements.Count; i++)
            {
                string currentWord = elements[i];

                counterCharacters += currentWord.Length;

                for (int j = 0; j < currentWord.Length; j++)
                {
                    totalWordSum += currentWord[j];
                }
            }
            char charDelimeter = (char)((int)totalWordSum / counterCharacters);
            string delimeter = charDelimeter.ToString().ToUpper();

            Console.WriteLine(string.Join(delimeter, elements));
        }
    }
}
