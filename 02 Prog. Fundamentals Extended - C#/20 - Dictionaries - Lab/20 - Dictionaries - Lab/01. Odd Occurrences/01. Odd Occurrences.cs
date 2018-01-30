using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            string[] arrInput = Console.ReadLine().ToLower().Split(' ');

            for (int i = 0; i < arrInput.Length; i++)
            {
                if (!words.ContainsKey(arrInput[i]))
                {
                    words.Add(arrInput[i], 0);
                }

                words[arrInput[i]]++; // uvelichavane na cnt na words
            }

            List<string> result = new List<string>();

            foreach (KeyValuePair<string, int> item in words)
            {
                if (item.Value % 2 == 1)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
