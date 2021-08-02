using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    public class Program
    { 
        static int uninit_int;  //C# uses default initialization
        static sbyte bar;       //signed byte
        static short foobar;    //2 bytes signed
        static int foo = 15;    //4 bytes signed
        static long baz;        //8 bytes signed
        static float floatFoo = 1.5f;  //7 digit precision floating point number
        //must explicity use the f decorator when initializing a float
        static double floatBar; // 15 digit precision floating point number
        bool bSwitch; //its a boolean, next question please
        char charFoo = 't'; //single byte charecter, must use single quotes
        string stringFoo = "t"; //string of chars, must use double quotes
        static void Main(string[] args)
        {
            Console.WriteLine(foo); //Output will be 15
            variable_scope();
            Console.WriteLine(foo); //Output will be 20
            Console.WriteLine(uninit_int); //Output will be 0
        }

        public static void variable_scope() {
            foo = 20;
        }
    }
}
