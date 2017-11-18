using System;

namespace TypeConversionApplication
{
    class ExplicitConversion
    {
        static void Main(string[] args)
        {
            double d = 5673.74;
            int i;

            // cast double to int.
            i = (int)d;
            Console.WriteLine(i);

            // Using C# Type Conversion Methods
            int x = 75;
            float f = 53.005f;
            double e = 2345.7652;
            bool b = true;

            Console.WriteLine(x.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(e.ToString());
            Console.WriteLine(b.ToString());
            Console.ReadKey();
        }
    }
}