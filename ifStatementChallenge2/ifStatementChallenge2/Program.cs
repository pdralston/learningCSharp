using System;

namespace ifStatementChallenge2
{
    class Program
    {
        private static int highscore = 0;
        private static string highscorePlayer = "";
        private const int MIN_NAME_SIZE = 3;
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.WriteLine("Enter Name: ");
                string player = Console.ReadLine();
                while (player.Length < MIN_NAME_SIZE)
                {
                    Console.WriteLine("Name must be at least three charecters. Please enter your name: ");
                    player = Console.ReadLine();
                }
                Console.WriteLine("Enter Score: ");
                int score;
                bool numberEntered = int.TryParse(Console.ReadLine(), out score);
                while (!numberEntered)
                {
                    Console.WriteLine("Score must be numeric, Enter your score: ");
                    numberEntered = int.TryParse(Console.ReadLine(), out score);
                }
                if (CheckScore(player, score))
                {
                    Console.WriteLine($"New highscore is {highscore}\n New highscore holder is {highscorePlayer}");
                }
                else
                {
                    Console.WriteLine($"The old highscore of {highscore} could not be broken and is still held by {highscorePlayer}");
                }
                
                Console.WriteLine("Press any key to continue, Esc to exit");
                cki = Console.ReadKey(true);
            } while (cki.Key != ConsoleKey.Escape);
        }

        public static bool CheckScore(string player, int score)
        {
            if (score > highscore)
            {
                highscorePlayer = player;
                highscore = score;
                return true;
            }
            return false;
        }
    }
}
