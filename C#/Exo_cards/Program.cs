using System.Drawing;
using Exo_cards.Enums;
using Exo_cards.Structs;

namespace Exo_cards
{
    public class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
        }

        private static void DisplayMenu()
        {
            int userInput = -1;
            do
            {
                Console.WriteLine("1. Battle Game");
                Console.WriteLine("0. Exit");
                Console.Write("Choose your game : ");
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    switch (userInput)
                    {
                        case 1:
                            {
                                Console.Clear();
                                new BattleGame();
                            }
                            break;
                        case 0: Environment.Exit(0);
                            break;
                        default:
                            {
                                Console.Clear();
                                userInput = -1;
                            }
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    userInput = -1;
                }
            }
            while (userInput == -1);
        }
    }
}
