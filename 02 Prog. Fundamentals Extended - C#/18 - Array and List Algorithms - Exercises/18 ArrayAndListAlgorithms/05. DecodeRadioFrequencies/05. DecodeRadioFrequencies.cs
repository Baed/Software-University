using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DecodeRadioFrequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frequenciesInput = Console.ReadLine().Split(' ');

            List<char> messageResult = new List<char>();
            
            for (int i = 0; i < frequenciesInput.Length; i++)
            {
                string[] tokens = frequenciesInput[i].Split('.');
                int firstFreq = int.Parse(tokens[0]);
                int secondFreq = int.Parse(tokens[1]);

                char firstLetter = (char)firstFreq;
                char secondLetter = (char)secondFreq;

                if (firstFreq != 0)
                {
                    messageResult.Insert(i, firstLetter);
                }

                if (secondFreq != 0)
                {
                    messageResult.Insert(messageResult.Count - 1 - i, secondLetter);
                }
            }

            messageResult.Reverse();
            Console.WriteLine(string.Join("", messageResult));
        }
    }
}
