using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictResult = new Dictionary<string, int>();

            string[] tokens = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);

            while (tokens[0] != "end")
            {
                string keyInput = tokens[0];
                string valueInput = tokens[1];

                int tempValue = 0;

                if (int.TryParse(valueInput, out tempValue))
                {
                    dictResult[keyInput] = tempValue;
                }

                else if (dictResult.ContainsKey(valueInput))
                {
                    dictResult[keyInput] = dictResult[valueInput];
                }

                tokens = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in dictResult)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }
        }
    }
}
