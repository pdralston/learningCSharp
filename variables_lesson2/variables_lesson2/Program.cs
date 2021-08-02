using System;

namespace variables_lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring a variable
            int num1;
            
            //assigning a value to a variable
            num1 = 13;
            
            //declare and init a var in one go
            int num2 = 23;
            int sum = num1 + num2;
            
            //declare multiple variables at once;
            int num3, num4, num5;
            
            Console.WriteLine(sum);

            //using concatination
            Console.WriteLine("num1 is " + num1);
            Console.WriteLine("num1 " + num1 + " + num2 " + num2 + " is " + sum);

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1  /  d2;
            Console.WriteLine("d1/d2 is " + dDiv);

            //must use the f decorator when assigning to a float var
            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            //note the lower precision
            Console.WriteLine("f1/f2 is " + fDiv);

            //mixed type division
            double dIDiv = d1 / num1;
            Console.WriteLine("f1/f2 is " + fDiv);
        }
    }
}
