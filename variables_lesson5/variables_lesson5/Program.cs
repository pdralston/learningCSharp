using System;

namespace variables_lesson5
{
    //Classes and Methods use PascalCasing U____I____
    //Classes use noun names
    //Methods use verb names
    class Program
    {
        //args/local vars are camelCased
        //avoid abreviations: userControl vs usrCtrl
        //avoid underscore: car_engine
        //exception to underscore is leading underscore _loginName is ok!
        //more consistent to use the primitives over classes
        static void Main(string[] args)
        {
            //implicit and explicit conversions
            double myDouble = 13.37;
            int myInt;

            //cast double to int
            //explicit conversion
            myInt = (int)myDouble;
            Console.WriteLine(myInt);

            //implicit conversion
            int num = 12390532;
            long bigNum = num;
            float myFloat = 13.37f;
            double myNewDouble = myFloat;
            Console.WriteLine(bigNum);
            Console.WriteLine(myNewDouble);

            //type conversion
            string myString = myDouble.ToString();
            string myFloatString = myFloat.ToString();
            Console.WriteLine(myString);
            Console.WriteLine(myFloatString);

            bool sunIsShinging = true;
            Console.WriteLine(sunIsShinging.ToString());

            //parse string to integer
            myString = "15";
            string mySecondString = "13";
            //this is concatination
            Console.WriteLine(myString + mySecondString);
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            //this is mathematic summation
            Console.WriteLine(num1 + num2);
        }
    }
}
