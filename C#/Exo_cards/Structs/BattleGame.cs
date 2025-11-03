using System.Linq;
using System.Numerics;

namespace Exo_cards.Structs
{
    public struct BattleGame
    {
        private Player[] _players;
        private Card[] _cardPlayed;
        private Trick _trick;

        public BattleGame()
        {
            int nbPlayer;
            do
            {
                Console.Write("How many players? ");
                int.TryParse(Console.ReadLine(), out nbPlayer);
            }
            while (nbPlayer <= 1);

            this._trick = new Trick();
            this._cardPlayed = new Card[nbPlayer];
            this._players = new Player[nbPlayer];

            #region distribute cards for all players

            Deck gameDeck = new Deck();
            int nbCards = (gameDeck.Cards.Length - (gameDeck.Cards.Length % nbPlayer)) / nbPlayer;
            for (int i = 0; i < this._players.Length; i++)
            {
                this._players[i] = new Player(new Deck(nbCards: 0));
            }
            this.DistributeCards(nbCards * this._players.Length, gameDeck);

            #endregion

            this.PlayGame();
        }

        private void DistributeCards(int totalCards, Deck gameDeck)
        {
            #region fill the players deck

            for (int i = 0; i < totalCards; i++)
            {
                int playerIndex = i % this._players.Length;
                this._players[playerIndex].AddCard(gameDeck.Cards[i]);
            }

            #endregion
        }

        private void PlayGame()
        {
            int turnNumber = 1;
            Card bestCard;
            do
            {
                Console.WriteLine($"Turn [{turnNumber}]\n---------");
                bestCard = this.PlayRound();
                if(this.HasBattle(bestCard))
                {
                    Console.WriteLine("Has battle!");
                    bestCard = this.PlayRoundBattle();
                }

                this.CalculateTurnResult(bestCard);
                turnNumber++;
                Array.ForEach(this._players, p => { Console.WriteLine($"current card for {p} : {p.CurrentDeck.Cards.Length}"); });
            }
            while (!this._players.Any(p => p.HandIsEmpty()));

            this.EndGame();
        }

        private Card PlayRound()
        {
            for (int i = 0; i < this._players.Length; i++)
            {
                if (!this._players[i].HandIsEmpty())
                {
                    this._cardPlayed[i] = this._players[i].RemoveFirstCard();
                    Console.WriteLine($"{this._players[i]} playing {this._cardPlayed[i]}");
                }
            }

            this._trick.AddCard(this._cardPlayed);
            return this.FindBestCard();
        }

        //TODO: refactor the block, i am here
        private Card PlayRoundBattle()
        {
            Card bestCard = this.FindBestCard();
            int nbBestCards = this._cardPlayed.Count(c => c.Value == bestCard.Value);
            int[] playersIndexBattle = new int[nbBestCards];
            Card[] battleCards = new Card[nbBestCards];

            int index = 0;
            bool isBattlePossible = true;
            for (int i = 0; i < this._cardPlayed.Length; i++)
            {
                if (this._cardPlayed[i].Value == bestCard.Value)
                {
                    playersIndexBattle[index] = i;
                    //check if all battle players can make the battle
                    isBattlePossible = isBattlePossible && this._players[i].CurrentDeck.HasNbCards(2);
                    index++;
                }
            }

            #region remove cards from players to play the battle

            //set face down + face up card (loop 2 times) TODO: refactor this code bloc
            int loop = 1, maxLoop = 2;
            while (loop <= maxLoop)
            {
                if (isBattlePossible)
                {
                    foreach (int playerIndex in playersIndexBattle)
                    {
                        //playerIndex equals "-1" if during the battle the player don't have enough cards
                        //already pass in .......
                        //TODO: refactor the block and review this code, i am here
                        if (playerIndex > -1)
                        {
                            if (!this._players[playerIndex].HandIsEmpty())
                            {
                                Card cardPlayed = this._players[playerIndex].RemoveFirstCard();
                                this._cardPlayed[playerIndex] = cardPlayed;
                                this._trick.AddCard(cardPlayed);
                            }

                            if (loop == 2)
                            {
                                Console.WriteLine($"{this._players[playerIndex]} playing {this._cardPlayed[playerIndex]}");
                            }
                        }
                    }

                    //restart battle loop if another battle occurred
                    if (loop == maxLoop)
                    {
                        for (int i = 0; i < battleCards.Length; i++)
                        {
                            //get lastest card added to the trick
                            battleCards[i] = this._trick.Cards[this._trick.Cards.Length - 1 - i];
                        }

                        bestCard = battleCards.Aggregate((best, next) => best.IsHigherThan(next) ? best : next);
                        //Console.WriteLine($"New Best Card {bestCard}");
                        if (battleCards.Count(c => c.Value == bestCard.Value) > 1)
                        {
                            Console.WriteLine("Another battle occurred!");
                            //restart 2 times the loop
                            loop = 0;
                        }
                    }
                    loop++;
                }
                else
                {
                    #region don't do the battle and empty the players deck who can not make the battle

                    for (int i = 0; i < playersIndexBattle.Length; i++)
                    {
                        Player player = this._players[playersIndexBattle[i]];
                        if (!player.CurrentDeck.HasNbCards(2))
                        {
                            Console.WriteLine($"{player} don't have enough card!");
                            Card removedCard = player.RemoveFirstCard();
                            this._trick.AddCard(removedCard);
                            this._cardPlayed[playersIndexBattle[i]] = removedCard;
                            playersIndexBattle[playersIndexBattle[i]] = -1;
                        }
                    }

                    #endregion
                }
            }

            #endregion

            return bestCard;
        }

        private Card FindBestCard()
        {
            return this._cardPlayed.Aggregate((best, next) => best.IsHigherThan(next) ? best : next);
        }

        private bool HasBattle(Card bestCard)
        {
            return this._cardPlayed.Count(c => c.Value == bestCard.Value) > 1;
        }

        private void EmptyPlayerDeck(Player player)
        {
            
        }

        private void CalculateTurnResult(Card bestCard)
        {
            Console.WriteLine($"Best {bestCard}");

            int indexBestCard = Array.IndexOf(this._cardPlayed, bestCard);
            //Console.WriteLine($"current ;;");
            //Array.ForEach(this._players[indexBestCard].CurrentDeck.Cards, c => { Console.WriteLine(c); });
            this._players[indexBestCard].AddCard(this._trick.Cards);
            this._trick.Clear();

            //Console.WriteLine($"CARDS FOR player {this._players[indexBestCard]}");
            //Array.ForEach(this._players[indexBestCard].CurrentDeck.Cards, c => { Console.WriteLine(c); });
        }

        private void EndGame()
        {
            //TODO: start new match if at least 2 have cards otherwise end the game and display winner
            while (true)
            {
                Console.Write("Start a new game? (y = Yes) ");
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.Key.Equals(ConsoleKey.Y))
                    break;
            }
            this.StartNewGame();
        }

        private void StartNewGame()
        {
            #region reset card arrays for starting a new game

            //for (int i = 0; i < this._players.Length; i++)
            //{
            //    this._cardPlayed = new Card[this._players.Length];
            //}

            #endregion

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("---------\nNew match\n---------");
            Console.ResetColor();
            this.PlayGame();
        }
    }
}