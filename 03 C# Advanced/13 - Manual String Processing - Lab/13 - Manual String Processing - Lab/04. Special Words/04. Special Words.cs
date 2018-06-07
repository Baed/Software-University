using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Special_Words
{
    class Program
    {
        //public static readonly string[] a = new[] { " ", "<", ">", "(", ")", "[", "]", ",", "-", "!", "?" };
        public static readonly char[] separator = " ()[]<>,-!?‘’".ToCharArray();

        static void Main(string[] args)
        {
            var serchedWords = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);

            var text = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);

            var data = new Dictionary<string, int>();

            foreach (var word in serchedWords)
            {
                data[word] = 0;
            }

            foreach (var word in text)
            {
                if (data.ContainsKey(word))
                {
                    data[word]++;
                }
            }
            Console.WriteLine(string.Join("\r\n", data.Select(kvp => $"{kvp.Key} - {kvp.Value}")));
        }
    }
}
