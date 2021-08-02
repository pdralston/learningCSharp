using System;

namespace variables_lesson4
{
    class Program
    {
        static int count = 2;
        /// <summary>
        /// Console Methods
        /// </summary>
        /// <param name="args">
        /// Command line args
        /// </param>
        static void Main(string[] args)
        {
            //avoid infinite loops
            if (count == 0) return;
            --count;
            int answer = 42;
            //print string arg without adding newline
            Console.Write("text here");
            //print string arg, add newline
            Console.WriteLine("text here");
            //Reads a single char and returns the ASCII Value
            Console.Read();
            //Read an entire line of input and return a string
            Console.ReadLine();
            //Captures the next keypress and returns a ConsoleKeyInfo object
            Console.ReadKey();
            //assigning a formatted string, note the $ to signify interpolated string
            string formattedString = $"This works because {answer} is the answer to life the universe and everything";
            Console.WriteLine(formattedString);

            //additional Console methods/properties explored
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            
            //see the effects of the additional console method calls
            Main(null);
        }
    }
}
