using System;

namespace Operators
{
    class Program
    {
       static int num = 0, num1 = 5, num2 = 3, num3, result;
        static void Main(string[] args)
        {
            //unary operators
            num3 = -num1; //unary - multiplies right hand side by -1
            Console.WriteLine($"num3 is {num3}");
            
            bool isSunny = true;
            Console.WriteLine($"is it sunny? {!isSunny}"); //! operator negates the right hand side

            //increment operator
            num++;
            Console.WriteLine($"num is {num}");
            Console.WriteLine($"num is {num++}");//num prints as 1 here
            Console.WriteLine($"num is {++num}");//num prints as 3 here

            //increment operator
            num--;
            Console.WriteLine($"num is {num}");
            Console.WriteLine($"num is {num--}");//num prints as 2 here
            Console.WriteLine($"num is {--num}");//num prints as 0 here

            //additive and multiplicative
            result = num1 + num2;
            Console.WriteLine($"num1 {num1} + num2 {num2} is {result}");
            result = num1 - num2;
            Console.WriteLine($"num1 {num1} - num2 {num2} is {result}");
            result = num1 * num2;
            Console.WriteLine($"num1 {num1} * num2 {num2} is {result}");
            result = num1 / num2;
            Console.WriteLine($"num1 {num1} / num2 {num2} is {result}");

            //relational
            bool isLower = num1 < num2;
            bool isHigher = num1 > num2;
            bool isEqual = num1 == num2;
            //this is all really basic shit. skipping ahead...

        }
    }
}
