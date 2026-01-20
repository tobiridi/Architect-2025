namespace Exo_cards.Structs
{
    public struct Player
    {
        private static byte NB_PLAYER = 1;

        public byte NumPlayer { get; private set; }
        public Deck CurrentDeck { get; private set; }

        public Player(Deck personalDeck)
        {
            this.CurrentDeck = personalDeck;
            this.NumPlayer = Player.NB_PLAYER;
            Player.NB_PLAYER++;
        }

        public bool HandIsEmpty() => this.CurrentDeck.Cards.Length == 0;

        public Card RemoveFirstCard()
        {
            Card removedCard = this.CurrentDeck.Cards[0];
            this.CurrentDeck = this.CurrentDeck.RemoveFirstCard();
            return removedCard;
        }

        public void AddCard(Card card)
        {
            this.CurrentDeck = this.CurrentDeck.AddCard(card);
        }

        public void AddCard(Card[] cards)
        {
            this.CurrentDeck = this.CurrentDeck.AddCard(cards);
        }

        public override string ToString()
        {
            return $"Player {this.NumPlayer}";
        }
    }
}
    