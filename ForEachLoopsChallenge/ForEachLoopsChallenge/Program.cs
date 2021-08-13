using System;
using System.Linq;

namespace ForEachLoopsChallenge
{
    class Program
    {
        public static readonly string[] DATA_TYPES = { "String", "Integer", "Boolean" };
        public const string ONLY_LETTERS = "@ ^[a - zA - Z] + $";
        static void Main(string[] args)
        {
            Console.Write("Enter a value: ");
            string line = Console.ReadLine();
            Console.Write($"Select the Data type to validate the input you have entered:\n{BuildOptionsList()}");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > DATA_TYPES.Length)
            {
                Console.WriteLine($"Please enter a numeric option between 1 and {DATA_TYPES.Length}");
            }
            Console.WriteLine($"You have entered a value: {line}");
            switch (option) 
            {
                case 1:
                    Console.WriteLine(GetValidStatement(line.All(Char.IsLetter), DATA_TYPES[option - 1]));
                    break;
                case 2:
                    Console.WriteLine(GetValidStatement(line.All(Char.IsDigit), DATA_TYPES[option - 1]));
                    break;
                case 3:
                    Console.WriteLine(GetValidStatement(line.ToLower().Equals("true") || line.ToLower().Equals("false"), DATA_TYPES[option - 1]));
                    break;
            }
            Console.WriteLine("Enter to continue, ESC to exit");
            if (Console.ReadKey(true).Key == ConsoleKey.Escape) return;
            Main(null);
        }
        public static string BuildOptionsList()
        {
            string output = "";
            for (int i = 0; i < DATA_TYPES.Length; ++i)
            {
                output += $"Press {i + 1} for {DATA_TYPES[i]}\n";
            }
            return output;
        }

        public static string GetValidStatement(bool bValid, string dataType) {
            return bValid ? $"It is a valid: {dataType}" : $"It is not a valid: {dataType}";
        }
    }

}
