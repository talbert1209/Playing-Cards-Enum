namespace Playing_Cards_Enum
{
    public class Card
    {
        public Suit Suit { get; set; }
        public Value Value { get; set; }
        public string Name { get; private set; }

        public Card(Suit suit, Value value)
        {
            Name = $"{value} of {suit}";
        }

    }
}