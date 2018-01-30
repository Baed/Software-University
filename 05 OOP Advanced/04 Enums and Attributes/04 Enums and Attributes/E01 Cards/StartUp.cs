namespace E01_Cards
{
    using E01_Cards.Tasks;
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            // Inputs for first to eight task

            //CardSuit();
            //CardRank();
            //CardPower();
            //CompareCards();
            //CustomEnumAttrs();
            //DeckOfCards();
            CardGame();
        }

        public static void CardSuit() // first task
        {
            var task1 = new CardSuit();
            task1.ResultPrinter(Console.ReadLine());
        }

        public static void CardRank() // second task
        {
            var task2 = new CardRank();
            task2.ResultPrinter(Console.ReadLine());
        }

        public static Card ReadCards() // read method for third and four task
        {
            string rank = Console.ReadLine();
            string suit = Console.ReadLine();

            var card = new Card(rank, suit);
            return card;
        }

        public static void CardPower() // third and four task
        {
            Card taskThreeAndFour = ReadCards();
            Console.WriteLine(taskThreeAndFour.ToString());
        }

        public static void CompareCards() // fifth task
        {
            Card first = ReadCards();
            Card second = ReadCards();

            if (first.CompareTo(second) > 0)
            {
                Console.WriteLine(first);
            }

            Console.WriteLine(second);
        }

        public static void CustomEnumAttrs() // sixth task
        {
            var custEnumAtt = new CustomEnumAttribute();
            custEnumAtt.PrintAttributes(Console.ReadLine());
        }

        public static void DeckOfCards() // seventh task
        {
            var decks = new DeckOfCards();
            decks.PrintDecks(Console.ReadLine()); // the order of enum printing is by him int values
        }

        public static void CardGame() // eight task
        {
            var playGame = new CardGame();
            playGame.GetInput();
        }
    }
}