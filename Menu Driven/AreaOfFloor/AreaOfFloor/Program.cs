using System;

namespace AreaOfFloor
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, Lenght, Width;
            Console.Write("Enter the lenght of room: ");
            Lenght = Double.Parse(Console.ReadLine());
            Console.Write("Enter the height of room: ");
            Width = double.Parse(Console.ReadLine());

            area = Lenght * Width;

            Console.Clear();

            Console.WriteLine("The Lenght is {0}", Lenght);
            Console.WriteLine("The Breadth is {0}", Width);
            Console.WriteLine("The area of floor is {0}", area);

            Console.ReadLine();

        }
    }
}
