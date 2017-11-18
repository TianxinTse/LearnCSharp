using System;

namespace RectangleApplication
{
    /* Public access specifier allows a class to expose its
     * member variables and member functions to other 
     * functions and objects. Any public member can be
     * accessed from outside the class. 
     */
    class Rectangle1
    {
        //member variables
        public double length;
        public double width;
        
        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle


    /* Private access specifier allows a class to hide its 
     * member variables and member functions from other 
     * functions and objects. Only functions of the same 
     * class can access its private members. Even an instance
     *  of a class cannot access its private members. 
     */
    class Rectangle2
    {
        //member variables
        private double length;
        private double width;

        public void Acceptdetails()
        {
            Console.WriteLine("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle


    /* Internal access specifier allows a class to expose its 
     * member variables and member functions to other functions 
     * and objects in the current assembly. In other words, any 
     * member with internal access specifier can be accessed 
     * from any class or method defined within the application 
     * in which the member is defined. 
     */
    class Rectangle3
    {
        //member variables
        internal double length;
        internal double width;

        double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle


    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            /* Rectangle1 has public lenght, width and public functions */
            Rectangle1 r1 = new Rectangle1();
            r1.length = 4.5;
            r1.width = 3.5;
            r1.Display();

            /* Rectangle2 has private lenght, width and public functions */
            Rectangle2 r2 = new Rectangle2();
            r2.Acceptdetails();
            r2.Display();

            /* Rectangle3 has internal lenght, width and public functions */
            Rectangle3 r3 = new Rectangle3();
            r3.length = 4.5;
            r3.width = 3.5;
            r3.Display();

            Console.ReadLine();
        }
    }
}
 