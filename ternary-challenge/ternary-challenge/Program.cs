using System;

namespace ternary_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                int temp;
                bool validTemp;
                Console.Write("Please enter a temperature: ");
                validTemp = int.TryParse(Console.ReadLine(), out temp);
                while (!validTemp)
                {
                    Console.Write("Not a valid temperature. Please enter a valid integer temperature: ");
                    validTemp = int.TryParse(Console.ReadLine(), out temp);
                }
                Console.WriteLine(temp > 28 ? "It is too hot here" : temp <= 15 ? "It is too cold here" : "It is ok");
                Console.WriteLine("Press any key to continue, ESC to exit: ");
                cki = Console.ReadKey(true);
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
