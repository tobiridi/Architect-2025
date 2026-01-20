using Exo_cards.Enums;

namespace Exo_cards.Structs
{
    public struct Deck
    {
        public Card[] Cards { get; set; }

        /// <summary>
        /// Create a new predefined deck with 52 cards shuffled.
        /// </summary>
        public Deck()
        {
            #region Filling the deck

            this.Cards = new Card[52];
            int index = 0;

            foreach (CardValue val in Enum.GetValues<CardValue>())
            {
                foreach (CardColor color in Enum.GetValues<CardColor>())
                {
                    this.Cards[index].Value = val;
                    this.Cards[index].Color = color;
                    index++;
                }
            }

            #endregion

            this.Shuffle();
        }

        /// <summary>
        /// Create a prefilled deck.
        /// </summary>
        /// <param name="cards">The cards to fulfill the deck.</param>
        public Deck(Card[] cards)
        {
            this.Cards = cards;
        }

        /// <summary>
        /// Create an empty deck allowing a fix number of cards.
        /// </summary>
        /// <param name="nbCards">Number of cards possible inside the deck.</param>
        public Deck(int nbCards)
        {
            if(nbCards <= 0)
                this.Cards = Array.Empty<Card>();
            else
                this.Cards = new Card[nbCards];
        }

        public void Shuffle() => new Random().Shuffle(this.Cards);

        public Deck AddCard(Card card)
        {
            this.Cards = [.. this.Cards, card];
            return this;
        }

        public Deck AddCard(Card[] cards)
        {
            this.Cards = [.. this.Cards, .. cards];
            return this;
        }

        public Deck RemoveFirstCard()
        {
            Card[] updatedCards = new Card[this.Cards.Length - 1];
            Array.Copy(this.Cards, 1, updatedCards, 0, updatedCards.Length);
            this.Cards = [.. updatedCards];

            return this;
        }

        public bool HasNbCards(int nbCards) => this.Cards.Length >= nbCards;
    }
}