using System;

namespace AreaOfFourWall
{
    class Program
    {
        static void Main(string[] args)
        {
            double Lenght, Breadth, Height, Area;

            Console.Write("Enter the Lenght of room: ");
            Lenght = double.Parse(Console.ReadLine());
            Console.Write("Enter the Breadth of room: ");
            Breadth = double.Parse(Console.ReadLine());
            Console.Write("Enter the Height of room: ");
            Height = double.Parse(Console.ReadLine());

            Area = (Lenght * Height) + (Lenght * Breadth) + (Breadth * Height);

            Console.Clear();

            Console.WriteLine("The lenght of wall is {0}", Lenght);
            Console.WriteLine("The Breadth of wall is {0}", Breadth);
            Console.WriteLine("The Height of wall is {0}", Height);
            Console.WriteLine("The Area of four wall is {0}", Area);

            Console.ReadLine();
        }
    }
}
