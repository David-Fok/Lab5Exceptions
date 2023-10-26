using System.Diagnostics;

namespace Lab5Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	One object with positive radius
            try
            {
                Circle circle1 = new Circle(10);
                Console.WriteLine(circle1);
            }
            catch(InvalidRadiusException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            //•	One object with negative radius
            try
            {
                Circle circle2 = new Circle(-10);
                Console.WriteLine(circle2);
            }
            catch(InvalidRadiusException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            //•	One object with radius of zero
            try
            {
                Circle circle3 = new Circle(0);
                Console.WriteLine(circle3);
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}