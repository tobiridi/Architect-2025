using C__reminder.Classes;
using C__reminder.Game;

namespace Remaining
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /* Part 1
             * variables
             * type casting
             * Math class
             * condition statement (if, else if, else, switch)
             * loop statement (for, while, do while, foreach)
             * "params" key word
             * Exception
             */
            //Variables();
            //GuessingGame();
            //LoopStatement();
            //decimal checkout = Checkout("tony", 10.50M, 22.36M, 12);
            //Console.WriteLine(checkout);
            //ExceptionManagement();

            //gameTicTacToe();

            /* Part 2 (see Folder 'Classes')
             * class
             */
            //Classes();

            
        }

        #region game tic tac toe

        public static void gameTicTacToe()
        {
            Player p1 = new Player(1, "toto", "X"), p2 = new Player(2, "tata", "O");
            TicTacToe game = new TicTacToe(p1, p2);

            game.DrawMap();
            game.PlayTurn(0, 0);
            game.DrawMap();
            game.PlayTurn(0, 1);
            game.DrawMap();
            game.PlayTurn(0, 2);
            game.DrawMap();
            game.PlayTurn(1, 0);
            game.DrawMap();
            game.PlayTurn(1, 1);
            game.DrawMap();
            game.PlayTurn(1, 2);
            game.DrawMap();
            game.PlayTurn(2, 0);
            game.DrawMap();
            game.PlayTurn(2, 1);
            game.DrawMap();
            game.PlayTurn(2, 2);
            game.DrawMap();
        }

        #endregion

        #region part 1

        private static void Variables()
        {
            //signed variables
            byte n1 = 243;
            short n2 = 22653;
            int n3 = 150;
            long n4 = 78945383641L;
            float n5 = 1.0f;
            double n6 = 789645.45132;
            decimal n7 = 7894864.654654M;
            bool n8 = true;
            string text = "Hello World!";
            char c = 'a';

            //unsigned variables
            uint un1 = 50;
            ushort un2 = 24136;
            ulong un3 = 789546123864L;

            //constant
            const int n10 = 55;

            //casting
            const double PI = 3.14;
            int a = Convert.ToInt32(PI);

            string text22 = "$";
            char chara = Convert.ToChar(text22);

            Console.WriteLine(a.GetType());
            Console.WriteLine(chara);

            //Math class
            Console.WriteLine($"pow : {Math.Pow(12, 2)}");
            Console.WriteLine($"square root : {Math.Sqrt(144)}");

            //Random number
            Console.WriteLine("Random number\n------");
            Random r = new Random();
            Console.WriteLine(r.Next(10));
            Console.WriteLine(r.NextInt64(664852L));

        }

        private static void GuessingGame()
        {
            Random r = new Random();
            int findedValue = r.Next(1, 101);
            Console.WriteLine("Find the number between 1 to 100\n---------------");
            int attempt = 0, input;

            do
            {
                Console.Write("Guess : ");
                input = Convert.ToInt32(Console.ReadLine());
                attempt++;
                if (input > findedValue)
                    Console.WriteLine($"{input} is too high");
                else if (input < findedValue)
                    Console.WriteLine($"{input} is too low");
            }
            while(input != findedValue);

            Console.WriteLine($"you find the number in {attempt} {(attempt > 1 ? "attempts" : "attempt")}");
        }

        private static void LoopStatement()
        {
            string[] names = { "tony", "toto", "tintin", "john", "anna" };
            Array.ForEach(names, n => Console.WriteLine(n));
        }

        /// <summary>
        /// This method use "params" key word, similar to ...variable in Java.<br/>
        /// 
        /// the variable "params" is an one dimension array of type.<br/>
        /// <code>
        /// in Java :
        /// Checkout(decimal... prices) {}
        /// </code>
        /// </summary>
        private static decimal Checkout(params decimal[] prices)
        {
            return prices.Sum();
        }

        private static decimal Checkout(string name, params decimal[] prices)
        {
            Console.WriteLine($"Calculate the total of the checkout for {name}");
            return Checkout(prices);
        }

        private static void ExceptionManagement()
        {
            try
            {
                Console.WriteLine(Convert.ToInt32("a"));
                //Console.WriteLine(Convert.ToInt32(7895462136484));
            }
            catch (FormatException ex) {
                Console.WriteLine("Error FormatException!");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error OverflowException!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Always executed!");
            }
        }

        #endregion

        #region part 2

        private static void Classes()
        {
            Message.Hello();
        }

        #endregion
    }
}
