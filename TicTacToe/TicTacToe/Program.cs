using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Board game = new Board();
            bool playGame = true;
            while (playGame)
            {
                game.Play();
                Console.Write("Press any key to continue, Esc to close: ");
                playGame = !Console.ReadKey(true).Key.Equals(ConsoleKey.Escape);
                if (playGame)
                {
                    game.ResetBoard();
                }
            }
            
        }
    }
}
