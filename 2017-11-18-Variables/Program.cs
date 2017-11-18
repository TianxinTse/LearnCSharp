using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declaration */
            short a;
            int b;
            double c;

            /* actual initialization */
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

            /* Accepting Values from User */
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your input is {0}", num);

            Console.ReadKey();
        }
    }
}
