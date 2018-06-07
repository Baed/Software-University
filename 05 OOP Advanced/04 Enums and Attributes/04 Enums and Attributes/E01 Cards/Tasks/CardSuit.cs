namespace E01_Cards.Tasks
{
    using System;

    public class CardSuit
    {
        public CardSuit()
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