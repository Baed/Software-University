using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new Dictionary<string, HashSet<string>>();

            var handout = Console.ReadLine();

            while (handout != "JOKER")
            {
                var tokens = handout.Split(':');

                var name = tokens[0];
                var cards = tokens[1].Split(',').Select(a => a.Trim()).ToArray();
                //.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!persons.ContainsKey(name))
                {
                    persons.Add(name, new HashSet<string>(cards));
                }
                persons[name].UnionWith(cards); // obedinqva vsi4ki unikalni elementi, ot razlichen tip na hashset v tozi slu4ai;

                handout = Console.ReadLine();
            }
            PrintResult(persons);
        }
        private static void PrintResult(Dictionary<string, HashSet<string>> persons)
        {
            foreach (var person in persons)
            {
                var score = CalculateScore(person.Value);
                Console.WriteLine($"{person.Key}: {score}");
            }
        }
        private static int CalculateScore(HashSet<string> cards)
        {
            var totalScore = 0;

            foreach (var card in cards)
            {
                char type = card.Last(); // Last symbol which is letter 
                string power = card.Substring(0, card.Length - 1); // first one or two symbol which is digit or letter

                int score;
                bool isDigit = int.TryParse(power, out score); // result = score

                if (!isDigit)
                {
                    switch (power) // first one or two which is a letter
                    {
                        case "J": score = 11; break;
                        case "Q": score = 12; break;
                        case "K": score = 13; break;
                        case "A": score = 14; break;
                    }
                }
                switch (type) // Last symbol which is always a letter 
                {
                    case 'S': score *= 4; break;
                    case 'H': score *= 3; break;
                    case 'D': score *= 2; break;
                    case 'C': score *= 1; break;
                }
                totalScore += score;
            }
            return totalScore;
        }
    }
}
