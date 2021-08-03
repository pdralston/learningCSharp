using System;

namespace methods_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = { "Jimmy", "Ronnie", "Jason" };
            foreach (string friend in friends) {
                GreetFriend(friend);
            }
        }

        public static void GreetFriend(string friend) {
            Console.WriteLine($"Hi {friend}, my friend!");
        }
    }
}
