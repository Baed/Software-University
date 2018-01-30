using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Deserialize_String
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, char> letterData = new SortedDictionary<int, char>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(':');
                char symbol = char.Parse(tokens[0]);
                int[] indices = tokens[1].Split('/').Select(int.Parse).ToArray();

                foreach (var index in indices)
                {
                    letterData[index] = symbol;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(letterData.Values.ToArray());
        }
    }
}
