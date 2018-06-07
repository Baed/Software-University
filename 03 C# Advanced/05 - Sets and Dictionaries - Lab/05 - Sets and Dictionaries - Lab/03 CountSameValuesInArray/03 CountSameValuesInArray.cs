using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                  .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(double.Parse)
                  .ToArray();
            var data = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if (!data.ContainsKey(num))
                {
                    data[num] = 0;
                }
                data[num]++;
            }
            foreach (var item in data)
            {
                Console.WriteLine(string.Join("\r\n", $"{item.Key} - {item.Value} times"));

            }
            //Console.WriteLine(string.Join(Environment.NewLine, data.Select(x => $"{x.Key} - {x.Value} times")));
        }
    }
}
