using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens =
                    input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];

                if (IsName(tokens[1]))
                {
                    string nameOftokensInput = tokens[1];

                    if (dict.ContainsKey(nameOftokensInput))
                    {
                        List<int> numbersOftokensInput = dict[nameOftokensInput];

                        if (!dict.ContainsKey(name))
                        {
                            dict.Add(name, new List<int>());
                        }
                        dict[name].Clear();
                        dict[name].AddRange(numbersOftokensInput);
                    }

                    input = Console.ReadLine();
                }
                else
                {
                    int[] numbers = tokens[1]
                        .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, new List<int>());
                    }

                    dict[name].AddRange(numbers); // vkarva celiq spisuk vmesto sus foreach

                    input = Console.ReadLine();
                }

            }

            foreach (KeyValuePair<string, List<int>> itemName in dict)
            {
                string nameResult = itemName.Key;
                List<int> numbersResult = itemName.Value;

                Console.WriteLine("{0} === {1}", nameResult, string.Join(", ", numbersResult));

            }
        }
        static bool IsName(string name)
        {
            foreach (var itemChar in name)
            {
                if (char.IsLetter(itemChar))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
