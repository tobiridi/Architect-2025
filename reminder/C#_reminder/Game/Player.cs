
namespace C__reminder.Game
{
    public class Player
    {
        public int Id { get; init; }
        public string Symbol;

        public Player (int id, string name, string symbol)
        {
            this.Id = id;
            this.Symbol = symbol;
        }

        public override string ToString()
        {
            return $"Player {this.Id} symbol ({this.Symbol})";
        }
    }
}
