using System;

namespace Area_nad_circumference_of_the_circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, Area, Circumference;
            double pi = Math.PI;
            Console.Write("\nEnter the radius of the circle: ");
            r = Convert.ToInt32(Console.ReadLine());
            Area = pi * r * r;
            Circumference = 2 * pi * r;
            Console.Clear();
            Console.WriteLine("Radius: {0}", r);
            Console.WriteLine("Area of Circle: {0}", Area);
            Console.WriteLine("Circumference of Circle: {0}", Circumference);
            Console.ReadLine();
        }
    }
}
