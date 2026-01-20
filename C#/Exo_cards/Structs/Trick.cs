namespace Exo_cards.Structs
{
    public struct Trick
    {
        public Card[] Cards { get; private set; }

        public Trick()
        {
            Cards = Array.Empty<Card>();
        }

        public void AddCard(Card[] cards)
        {
            this.Cards = [.. this.Cards, .. cards];
        }

        public void AddCard(Card card)
        {
            this.Cards = [.. this.Cards, card];
        }

        public void Clear() => this.Cards = [];
    }
}