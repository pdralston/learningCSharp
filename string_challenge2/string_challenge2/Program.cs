using System;

namespace string_challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            string value, firstName, lastName, fullName;
            char searchValue;
            int index;
            Console.WriteLine("Enter a string here: ");
            value = Console.ReadLine();
            Console.WriteLine("Enter the character to search: ");
            searchValue = (char)Console.ReadKey(true).Key;
            index = value.IndexOf(searchValue);
            if (searchValue >= 0)
            {
                Console.WriteLine($"{searchValue} found at index {index}");
            } else {
                Console.WriteLine("Charecter not found in String");
            }
            Console.WriteLine("Enter your first name : ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name : ");
            lastName = Console.ReadLine();
            fullName = String.Concat(firstName, " ", lastName);
            Console.WriteLine($"Thank you {fullName}");
        }
    }
}
