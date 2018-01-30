namespace E01_Cards.Tasks
{
    using System;
    using System.Collections.Generic;

    internal class DeckOfCards
    {
        public DeckOfCards()
        {
        }

        public void PrintDecks(string input)
        {
            List<Card> deck = GenerateDeck();

            foreach (var card in deck)
            {
                Console.WriteLine(card.Name);
            }
        }

        public static List<Card> GenerateDeck()
        {
            var deck = new List<Card>();

            foreach (var suit in Enum.GetNames(typeof(Suit)))
            {
                foreach (var rank in Enum.GetNames(typeof(Rank)))
                {
                    deck.Add(new Card(rank, suit));
                }
            }

            return deck;
        }
    }
}