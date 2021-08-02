using System;

namespace variables_lesson3
{
    class Program
    {
        ///<summary>
        /// This is an XML doc comment
        /// </summary>
        static void Main(string[] args)
        {
            string myname = "David";
            string message = "My name is " + myname;

            string capsMessage = message.ToUpper();
            string lowerMessage = message.ToLower();

            Console.WriteLine(message);
            Console.WriteLine(capsMessage);
            Console.WriteLine(lowerMessage);
        }
    }
}
