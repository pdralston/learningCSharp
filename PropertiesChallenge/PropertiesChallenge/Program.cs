using System;

namespace PropertiesChallenge
{   
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box(1,2,3);
            Console.WriteLine($"{box1}\n\n{box2}");

        }
    }
}
