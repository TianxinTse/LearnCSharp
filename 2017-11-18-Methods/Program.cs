using System;

namespace CalculatorApplication
{
    class NumberManipulator
    {
        public int FindMax(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }

        public int factorial(int num)
        {
            return num == 1 ? 1 : factorial(num - 1) * num;
        }
    }


    class Test
    {
        static void Main(string[] args)
        {
            /* local variable definition */
            int a = 100;
            int b = 200;
            int ret;
            NumberManipulator nm = new NumberManipulator();

            /* calling the FindMax method */
            ret = nm.FindMax(a, b);
            Console.WriteLine("Max value is : {0}", ret);

            /* calling the factorial method */
            Console.WriteLine("Factorial of 6 is : {0}", nm.factorial(6));
            Console.WriteLine("Factorial of 7 is : {0}", nm.factorial(7));
            Console.WriteLine("Factorial of 8 is : {0}", nm.factorial(8));

            Console.ReadKey();
        }
    }
}
