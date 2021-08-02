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
            myInt = (int)myDouble;
            Console.WriteLine(myInt);

        }
    }
}
