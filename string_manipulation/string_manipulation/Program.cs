using System;

namespace string_manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 31;
            string name = "Alfonso";
            
            //concatination
            Console.WriteLine("Hello, my name is " + name + ", I am " + age + " years old");

            //formatting
            Console.WriteLine("Hello my name is {0}, I am {1} years old");
            
            //interpolation
            Console.WriteLine($"Hello my name is {name}, I am {age} years old");

            //verbatim strings
            //ignores escape and special charecters, prints as written
            Console.WriteLine(
                @"
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla maximus tortor quis nisi fringilla, vitae congue lectus fermentum. Morbi ligula eros,
                imperdiet non aliquam eget, vestibulum quis felis. Aliquam eu auctor mauris, at efficitur lectus. Suspendisse turpis nisl, venenatis eu eros
                porttitor, elementum interdum tellus. In luctus quis urna at egestas. Vivamus vitae urna semper, ullamcorper ipsum tempor, iaculis odio. Mauris sapien
                libero, mattis non vestibulum in, consequat vel arcu. Integer dignissim tortor at arcu posuere, nec elementum ante molestie. Aenean ut odio urna.
                Donec vitae purus efficitur, laoreet metus non, placerat metus. Nullam tincidunt risus sit amet ante luctus efficitur.

                Nulla facilisi. Suspendisse ipsum ex, commodo sed massa ac, malesuada tempor turpis. Sed tellus tellus, congue non ultrices eu, venenatis sed mauris.
                Fusce sit amet bibendum ante. Morbi eu risus vitae eros efficitur placerat vel sit amet odio. Aliquam erat volutpat. In quis ipsum arcu. Aliquam
                cursus quam non tellus scelerisque, id convallis orci finibus. Vestibulum nec laoreet est. Quisque ex mauris, consectetur a erat vel, consequat
                placerat enim. Curabitur dui sapien, faucibus ac vulputate commodo, ultricies sit amet mi. Nam vulputate eu neque vulputate dignissim. Mauris
                tincidunt felis enim, non imperdiet nunc scelerisque non. Nam auctor tincidunt est vel convallis. Ut nulla lorem, dapibus at tellus ut, gravida
                pharetra eros.

                Vestibulum non quam pharetra, tristique purus vitae, porttitor ipsum. Mauris at neque ut magna molestie semper. Nullam sit amet nisl suscipit,
                efficitur ex quis, tempus dui. Proin rutrum diam sed sodales pulvinar. Proin in velit a leo consequat efficitur. Integer euismod cursus enim at
                bibendum. Mauris ut molestie metus.

                Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Orci varius natoque penatibus et magnis dis parturient montes,
                nascetur ridiculus mus. Pellentesque eleifend scelerisque tortor a sollicitudin. Mauris eros dolor, congue vel ultrices at, ullamcorper eget nulla.
                Nunc faucibus quis elit eu tincidunt. Nullam et elit eu ipsum blandit tempor. Vivamus ultrices, tellus convallis tempus condimentum, neque libero
                euismod velit, accumsan viverra eros purus eget lorem. Nam pharetra neque ac lorem tristique mattis. Nulla facilisi. Pellentesque non consectetur mi.
                Sed eu est ut nibh eleifend luctus. Phasellus consequat augue sit amet tellus eleifend, sed lobortis diam vulputate. Integer varius ligula et purus
                ullamcorper, in suscipit ligula sollicitudin.
                ");
            //verbatim strings are useful for things like paths that utilize \

            //C# has both String and string types
            //String Methods
            //String.SubString(int32) returns a substring from supplied index
            //ToLower() and ToUpper() return a string with case matching the function name 
            //Trim() remove all leading and trailing whitespace
            //IndexOf(string) return the index of first instance of the substring
            //IsNullOrWhiteSpace() returns true if the string is either or blank
            string firstName = "David";
            string lastName = "Ralston";
            string fullName = string.Concat(" ", firstName, lastName, " ");
            Console.WriteLine(firstName.Substring(2));                    //output: "vid"
            //alternative to Substring, range operator
            Console.WriteLine(firstName[2..]);                             //output: "vid"
            Console.WriteLine(firstName.ToLower());                        //output: "david"
            Console.WriteLine(firstName.ToUpper());                        //output: "DAVID"
            Console.WriteLine(fullName.Trim());                            //output: "DavidRalston"
            Console.WriteLine(firstName.IndexOf('a'));                     //output: 1
            Console.WriteLine(String.IsNullOrWhiteSpace(firstName));       //output: false
            Console.WriteLine(String.Format("My name is {0}", firstName)); //output: "My name is David"
        }
    }
}
