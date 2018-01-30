using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._02_Array_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> counts = new Dictionary<string, long>();

            string[] inputStrings = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < inputStrings.Length; i++)
            {
                if (!counts.ContainsKey(inputStrings[i]))
                {
                    counts.Add(inputStrings[i], 0);
                }
                counts[inputStrings[i]]++;
            }
            foreach (KeyValuePair<string, long> item in counts)
            {
                Console.WriteLine(item.Key + " = === = " + item.Value);
            }
        }
    }
}
