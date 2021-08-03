using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace functions_2
{
    class Program
    {
        static private List<ConsoleKey> validOperations = new List<ConsoleKey>() { ConsoleKey.Add, ConsoleKey.Subtract, ConsoleKey.Multiply, ConsoleKey.Divide };
        static private List<Func<int, int, int>> mathOperations = new List<Func<int, int, int>>() {Add, Subtract, Multiply, Divide};
        static void Main(string[] args)
        {
            int x = 0, y = 0, operation;
            GetNumbers(ref x, ref y);
            operation = GetOperation();
            mathOperations[operation](x, y);
        }

        public static void GetNumbers(ref int num1, ref int num2) {
            Console.WriteLine("Enter 2 Numbers : ");
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, @"\d+");
            while (matches.Count == 0) {
                Console.WriteLine("Error: please enter 2 numbers : ");
                input = Console.ReadLine();
                matches = Regex.Matches(input, @"\d+");
            }
            num1 = int.Parse(matches[0].ToString());
            if (matches.Count == 1)
            {
                //empty list of matches
                matches = Regex.Matches("", @"\d+");
                while (matches.Count == 0)
                {
                    Console.WriteLine("Please enter one more number : ");
                    input = Console.ReadLine();
                    matches = Regex.Matches(input, @"\d+");
                }
                num2 = int.Parse(matches[0].ToString());
            } else {
                num2 = int.Parse(matches[1].ToString());
            }
        }

        public static int GetOperation() {
            Console.WriteLine("Enter an Operation (+, -, *, /) : ");
            ConsoleKeyInfo operation = Console.ReadKey(true);

            while (!validOperations.Contains(operation.Key)) {
                Console.WriteLine("Invalid Operation supplied, Please enter a valid operation (+, -, *, /) : ");
                operation = Console.ReadKey(true);
            }
            return validOperations.IndexOf(operation.Key);
        }

        public static int Add(int num1, int num2) {
            int result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result}");
            return result;
        }

        public static int Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            return result;
        }

        public static int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {result}");
            return result;
        }

        public static int Divide(int num1, int num2)
        {
            if (num2 == 0) {
                Console.WriteLine("Error: Divide By Zero");
                return 0;
            }
            int result = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {result}");
            return result;
        }
    }
}
