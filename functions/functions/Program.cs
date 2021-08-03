using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 40, y = 2;
            WriteSomething();
            WriteSomethingSpecific("I am an argument. I am called from a method.");
            WriteSomethingSpecific(Add(x, y).ToString());
            WriteSomethingSpecific(Mult(x, y).ToString());
        }

        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method.");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        public static int Add(int num1, int num2) {
            return num1 + num2;
        }

        public static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Div(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
