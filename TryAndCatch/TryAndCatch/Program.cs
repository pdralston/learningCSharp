using System;
using System.Collections.Generic;

namespace TryAndCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally 
            { 
                Console.WriteLine("This code is ran regardless of resolution of the try catch block.")    
            }
        }
    }
}
