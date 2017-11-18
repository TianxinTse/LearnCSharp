using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowSizeOfDataTypes();
            ShowObjectType();
            ShowDynamicType();
            ShowStringType();

            Console.ReadLine();
        }

        private static void ShowSizeOfDataTypes()
        {
            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.WriteLine("Size of bool: {0}", sizeof(bool));
            Console.WriteLine("Size of byte: {0}", sizeof(byte));
            Console.WriteLine("Size of char: {0}", sizeof(char));
            Console.WriteLine("Size of decimal: {0}", sizeof(decimal));
            Console.WriteLine("Size of double: {0}", sizeof(double));
            Console.WriteLine("Size of float: {0}", sizeof(float));
            Console.WriteLine("Size of long: {0}", sizeof(long));
            Console.WriteLine("Size of sbyte: {0}", sizeof(sbyte));
            Console.WriteLine("Size of short: {0}", sizeof(short));
            Console.WriteLine("Size of uint: {0}", sizeof(uint));
            Console.WriteLine("Size of ulong: {0}", sizeof(ulong));
            Console.WriteLine("Size of ushort: {0}", sizeof(ushort));
        }

        /*
         Dynamic types are similar to object types except that type checking for 
         object type variables takes place at compile time, whereas that for the
         dynamic type variables takes place at run time.
             */

        private static void ShowObjectType()
        {
            object obj;
            obj = 100; // this is boxing
            Console.WriteLine(obj);
        }

        private static void ShowDynamicType()
        {
            dynamic d = 20;
            Console.WriteLine(d);
        }

        private static void ShowStringType()
        {
            String str = "Tutorials Point";
            Console.WriteLine(str);

            // @ character can make compiler ignore escape characters
            String path = @"C:\Python36\python";
            Console.WriteLine(path);
        }

        private static void ShowPointerType()
        {
            // using pointers is unsafe in C#
            // char* cptr;
            // int* iptr;
        }
    }
}
