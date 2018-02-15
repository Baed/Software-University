using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._01_HandsOfCards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> powerOfType = new Dictionary<string, int>() { { "S", 4 }, { "H", 3 }, { "D", 2 }, { "C", 1 } };

            Dictionary<string, int> data = new Dictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "JOKER")
            {
                string name = input.Substring(0, input.IndexOf(":"));
                List<string> cards = input
                    .Substring(input.IndexOf(":") + 2)
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Distinct()
                    .ToList();


                foreach (var card in cards)
                {
                    int score = 0;
                    int powerOfCard = 0;

                    int indexOfSuit = card.IndexOfAny(new[] { 'S', 'H', 'D', 'C' });
                    string suit = card.Substring(indexOfSuit);
                    string cardPower = card.Substring(0, indexOfSuit);

                    int power;
                    bool result = int.TryParse(cardPower, out power);

                    if (result)
                    {
                        powerOfCard = power;
                    }
                    else
                    {
                        switch (cardPower)
                        {
                            case "J": powerOfCard = 11; break;
                            case "Q": powerOfCard = 12; break;
                            case "K": powerOfCard = 13; break;
                            case "A": powerOfCard = 14; break;
                        }
                    }

                    score = powerOfCard * powerOfType[suit];

                    Console.WriteLine($"PersonScore:{data[name]}, card: {card},  suit: {suit}, (power x suitPower) = {powerOfCard} x {powerOfType[suit]} = {score}");

                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, 0);
                    }
                    data[name] += score;                   
                }
            }

            foreach (var card in data)
            {
                Console.WriteLine($"{card.Key}: {card.Value}");
            }
        }
    }
}
