namespace E01_Cards.Tasks
{
    using System;

    internal class CardRank
    {
        public CardRank()
        {
        }

        public void ResultPrinter(string input)
        {
            Console.WriteLine(input + ":");

            foreach (var value in Enum.GetValues(typeof(Suit)))
            {
                Console.WriteLine($"Ordinal value: {(int)value}; Name value: {value}");
            }
        }
    }
}