using System;
using System.Collections.Generic;

namespace if_statement_challenge
{
    class Program
    {
        class User {
            private string username;
            private int password;
            public User(string name, int pass) => (this.username, password) = (name, pass);
            public User(string name, string pass) : this(name, pass.GetHashCode()) { }
            public override bool Equals(Object obj)
            {
                return this.username == ((User) obj).username && this.password == ((User) obj).password; 
            }
            public string GetUsername()
            {
                return this.username;
            }
        }

        private static List<User> users = new List<User>() { new User("Admin", "password123") };
        private static string loggedInUser = "";
        private static bool runProgram = true;
        static void Main(string[] args)
        {
            
            while (runProgram)
            {
                Console.Clear();
                PrintMenu();
                ConsoleKey entry = Console.ReadKey(true).Key;
                string name = "", pass = "";
                switch (entry)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        CollectCredentials(ref name, ref pass);
                        if (Register(name, pass))
                        {

                            if (loggedInUser == "" && Login(name, pass)) {
                                loggedInUser = name;
                                Console.WriteLine($"Welcome, {name}! you are now logged in");
                            } 
                            else
                            {
                                Console.WriteLine($"Thank you for registering {name}. {loggedInUser} is already logged in, please log them out to sign yourself in.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("That user already exists! Please try again.");
                        }
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        if (loggedInUser != "")
                        {
                            Console.WriteLine($"{loggedInUser} is already logged in, please log them out to sign yourself in.");
                            break;
                        }
                        CollectCredentials(ref name, ref pass);
                        if (Login(name, pass))
                        {
                            loggedInUser = name;
                            Console.WriteLine($"Welcome, {name}! you are now logged in");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Credentials, please try again.");
                        }
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        if (loggedInUser == "")
                        {
                            Console.WriteLine("No one is logged in right now");
                        } else
                        {
                            Console.WriteLine($"{loggedInUser} logged out!");
                            loggedInUser = "";
                        }
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        return;
                    default:
                        Console.WriteLine("Invalid Selection");
                        break;
                }
                PressAnyKey();
            }
            
        }

        private static bool Login(string name, string pass)
        {
            return users.Contains(new User(name, pass));
        }

        private static bool FindUser(string name) {
            foreach (User user in users) {
                if (user.GetUsername() == name)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool Register(string name, string pass) {
            if (FindUser(name)) {
                return false;
            }
            users.Add(new User(name, pass));
            return true;
        }

        private static void CollectCredentials(ref string name, ref string pass)
        {
            Console.WriteLine("Please enter your Username:");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your Password:");
            pass = Console.ReadLine();
        }

        private static void PrintMenu()
        {
            Console.WriteLine("1. Register\n2. Login\n3. Logout\n4. Exit\nPlease key in your selection");
        }
        private static void PressAnyKey() {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
        }
    }
}
