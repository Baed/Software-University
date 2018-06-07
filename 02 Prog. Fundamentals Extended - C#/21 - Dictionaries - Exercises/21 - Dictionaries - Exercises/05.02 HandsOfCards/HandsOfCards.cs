using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        Dictionary<string, int> suitData = new Dictionary<string, int>() { { "S", 4 }, { "H", 3 }, { "D", 2 }, { "C", 1 } };

        Dictionary<string, HashSet<string>> data = new Dictionary<string, HashSet<string>>();

        string inputLine;
        while ((inputLine = Console.ReadLine()) != "JOKER")
        {
            List<string> entry = inputLine.Split(':').ToList();
            List<string> cards = entry[1]
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)             
                .ToList();

            string person = entry[0].Trim();

            if (!data.ContainsKey(person))
            {
                data.Add(person, new HashSet<string>());
            }

            foreach (var card in cards)
            {
                data[person].Add(card);
            }
        }

        foreach (var hands in data)
        {
            string nameOfPerson = hands.Key;
            int scorePerPerson = 0;

            foreach (var card in hands.Value)
            {
                string cardType = card.Substring(0, card.Length - 1);
                string suitType = card.Substring(cardType.Length);

                int power = 0;
                int suit = 0;

                int parser;               
                bool tryToParse = int.TryParse(cardType, out parser);
                if (tryToParse)
                {
                    power = parser;
                }
                else
                {
                    switch (cardType)
                    {
                        case "J": power = 11; break;
                        case "Q": power = 12; break;
                        case "K": power = 13; break;
                        case "A": power = 14; break;
                    }
                }
                scorePerPerson += power * suitData[suitType];
            }
            Console.WriteLine("{0}: {1}", nameOfPerson, scorePerPerson);
        }
    }
}