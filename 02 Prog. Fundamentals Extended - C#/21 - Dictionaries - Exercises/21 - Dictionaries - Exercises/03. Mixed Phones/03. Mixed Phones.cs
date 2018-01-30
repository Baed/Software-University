using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mixed_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, long> phonebook = new SortedDictionary<string, long>();

            while (true)
            {
                List<string> tokens = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (tokens[0] == "Over")
                {
                    break;
                }
                string firstElementOfTokens = tokens[0];
                string secondElementOfTokens = tokens[1];

                int value; // int value = 0;

                if (int.TryParse(firstElementOfTokens, out value))
                {
                    phonebook[secondElementOfTokens] = value;
                }
                else
                {
                    phonebook[firstElementOfTokens] = long.Parse(secondElementOfTokens);
                }
            }

            foreach (var elements in phonebook)
            {
                Console.WriteLine($"{elements.Key} -> {elements.Value}");
            }
        }
    }
}
