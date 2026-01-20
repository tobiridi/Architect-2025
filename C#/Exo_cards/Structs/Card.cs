using Exo_cards.Enums;

namespace Exo_cards.Structs
{
    public struct Card
    {
        public CardColor Color { get; set; }
        public CardValue Value { get; set; }

        public Card(CardColor color, CardValue value)
        {
            this.Color = color;
            this.Value = value;
        }

        public override string ToString()
        {
            return $"Card : [{Value}, {Color}]";
        }

        public bool IsHigherThan(Card card)
        {
            return this.Value.CompareTo(card.Value) > 0;
        }
    }
}
