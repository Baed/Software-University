using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Letter_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> resultDict = new Dictionary<char, int>();

            string input = Console.ReadLine();
            char[] textArr = input.ToCharArray();

            foreach (var character in textArr)
            {
                if (!resultDict.ContainsKey(character))
                {
                    resultDict.Add(character, 0);
                }
                resultDict[character]++;
            }

            foreach (var item in resultDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
