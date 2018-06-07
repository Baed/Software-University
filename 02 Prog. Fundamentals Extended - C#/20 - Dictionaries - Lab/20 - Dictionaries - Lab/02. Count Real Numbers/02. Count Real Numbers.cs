using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numberDict = new SortedDictionary<double, int>();

            double[] inputNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (!numberDict.ContainsKey(inputNumbers[i]))
                {
                    numberDict.Add(inputNumbers[i], 0);
                }
                numberDict[inputNumbers[i]]++;
            }

            foreach (var num in numberDict.Keys)
            {
                Console.WriteLine($"{num} -> {numberDict[num]}");
            }
            /*
            foreach (var item in numbersCount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value} times");
            }
            */
            foreach (KeyValuePair<double, int> num in numberDict.OrderByDescending(n => n.Value))
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
