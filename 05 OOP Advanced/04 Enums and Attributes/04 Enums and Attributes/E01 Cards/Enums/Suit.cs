namespace E01_Cards
{
    using System;

    [Type("Suit", "Provides suit constants for a Card class.")]
    public enum Suit : byte
    {
        Clubs = 0,
        Diamonds = 13,
        Hearts = 26,
        Spades = 39
    }
}