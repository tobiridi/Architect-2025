namespace C__reminder.Game
{
    public class TicTacToe
    {
        private Player P1;
        private Player P2;
        private string[][] GameMap;
        private Player NextPlayer;
            

        public TicTacToe(Player p1, Player p2)
        {
            this.GameMap = [[ "___", "___", "___"], ["___", "___", "___"], ["___", "___", "___"]];
            this.P1 = p1;
            this.P2 = p2;
            this.NextPlayer = p1;
        }

        public void DrawMap()
        {
            Console.WriteLine(" ___ ___ ___");
            for (int i = 0; i < this.GameMap.Length; i++)
            {
                Console.WriteLine($"|   |   |   |");
                Console.WriteLine($"|{(this.GameMap[i][0].Equals("___") ? "   " : this.GameMap[i][0])}|{(this.GameMap[i][1].Equals("___") ? "   " : this.GameMap[i][1])}|{(this.GameMap[i][2].Equals("___") ? "   " : this.GameMap[i][2])}|");
                Console.WriteLine($"|___|___|___|");
            }
        }

        public void PlayTurn(int posx, int posy)
        {
            Console.WriteLine($"{this.NextPlayer}");
            this.GameMap[posx][posy] = $" {this.NextPlayer.Symbol} ";
            if (this.NextPlayer == this.P1)
                this.NextPlayer = P2;
            else
                this.NextPlayer = P1;
        }
    }
}
