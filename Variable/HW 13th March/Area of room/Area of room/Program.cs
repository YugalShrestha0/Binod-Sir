using System;

namespace Area_of_room
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, b, Area;
            Console.Write("\nEnter the Lenght of the room: ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the breadth of the room: ");
            b = Convert.ToInt32(Console.ReadLine());
            Area = l * b;
            Console.Clear();
            Console.WriteLine("Lenght of the room: {0}", l);
            Console.WriteLine("Breadth of the room: {0}", b);
            Console.WriteLine("Area of room: {0}", Area);
            Console.ReadLine();
        }
    }
}
