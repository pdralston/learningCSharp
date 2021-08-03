using System;

namespace string_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Please enter your name and press enter");
            name = Console.ReadLine();
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Trim());
            Console.WriteLine(name.Substring(2));
        }
    }
}
