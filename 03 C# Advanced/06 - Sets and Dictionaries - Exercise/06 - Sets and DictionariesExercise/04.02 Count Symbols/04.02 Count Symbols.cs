using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._02_Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToCharArray();
            var dict = new SortedDictionary<char, int>();

            foreach (var symbol in text)
            {
                if (!dict.ContainsKey(symbol))
                {
                    dict[symbol] = 0;
                }

                dict[symbol]++;
            }

            Console.WriteLine(string.Join(Environment.NewLine, dict
                .Select(kvp => $"{kvp.Key}: {kvp.Value} time/s")));
        }
    }
    }
}
