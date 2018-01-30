using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var data = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                var symbols = text.ToCharArray();
                if (!data.ContainsKey(symbols[i]))
                {
                    data[symbols[i]] = 0;
                }
                data[symbols[i]]++;
            }

            foreach (var item in data)
            {
                Console.WriteLine(string.Join("\r\n", $"{item.Key}: {item.Value} time/s"));
            }
        }
    }
}
