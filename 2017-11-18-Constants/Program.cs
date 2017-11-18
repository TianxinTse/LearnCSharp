using System;

namespace _2017_11_18_Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Integer Literals:
             
                212        // Legal
                215u       // Legal
                0xFeeL     // Legal
                85         // decimal
                0x4b       // hexadecimal
                30         // int
                30u        // unsigned int
                30l        // long
                30ul       // unsigned long
             */

            /* Floating-point Literals:
            
                3.14159       // Legal
                314159E-5F    // Legal
                510E          // Illegal: incomplete exponent
                210f          // Illegal: no decimal or exponent
                .e55          // Illegal: missing integer or fraction
             */

            /* escape sequence characters */
            Console.WriteLine("Hello\tWorld\n\n");
            /* Console.ReadLine(); */

            /* You can break a long line into multiple lines using
               string literals and separating the parts using whitespaces:

                "hello, dear"
                "hello, \
                dear"
                "hello, " "d" "ear"
                @"hello dear"
             */

            /* Defining Constants as follows:
             
                const <data_type> <constant_name> = value;
             */

            // constant declaration 
            const double pi = 3.14159;

            double r;
            Console.WriteLine("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            Console.ReadLine();
        }
    }
}
