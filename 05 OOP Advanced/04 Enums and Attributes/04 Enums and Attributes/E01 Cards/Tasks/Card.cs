namespace E01_Cards
{
    using System;

    public class Card : IComparable<Card>
    {
        public Card(string rank, string suit)
        {
            this.Rank = (Rank)Enum.Parse(typeof(Rank), rank);
            this.Suit = (Suit)Enum.Parse(typeof(Suit), suit); ;
        }

        public Rank Rank { get; set; }

        public Suit Suit { get; set; }

        public int Power // we get them values
        {
            get { return (int)this.Rank + (int)this.Suit; }
        }

        public string Name
        {
            get { return this.Rank + " of " + this.Suit; }
        }

        public int CompareTo(Card otherCard)
        {
            if (ReferenceEquals(this, otherCard))
            {
                return 0;
            }
            if (ReferenceEquals(null, otherCard))
            {
                return 1;
            }
            var rankComparison = this.Suit.CompareTo(otherCard.Suit);

            if (rankComparison != 0)
            {
                return rankComparison;
            }

            return this.Rank.CompareTo(otherCard.Rank);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Card card = obj as Card;

            return this.Power.Equals(card.Power);
        }

        public override string ToString()
        {
            return $"Card name: {this.Name}; Card power: {this.Power}";
        }
    }
}