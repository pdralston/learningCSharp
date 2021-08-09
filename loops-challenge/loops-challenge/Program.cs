using System;
using System.Linq;
using System.Collections.Generic;

namespace loops_challenge
{
    delegate void genericFunc(string toPrint);
    class Program
    {
        private const string INPUT_COMPLETE_VALUE = "-1";
        private const int MIN_SCORE = 0, MAX_SCORE = 20;
        static void Main(string[] args)
        {
            List<int> scores = new List<int>();
            string input = "";
            int score;
            while (true)
            {
                Console.Write("Please enter a score, -1 to finish: ");
                input = Console.ReadLine();
                if (input == INPUT_COMPLETE_VALUE) break;
                if (!int.TryParse(input, out score))
                {
                    Console.WriteLine("Please only enter numbers.");
                    continue;
                }
                if (score < MIN_SCORE || score > MAX_SCORE)
                {
                    Console.WriteLine("Scores must be between 0 and 20, inclusive.");
                    continue;
                }
                scores.Add(score);
            }
            Console.WriteLine($"The class had an average of: {(scores.Count > 0 ? Enumerable.Average(scores) : 0)}");
        }
    }
}
