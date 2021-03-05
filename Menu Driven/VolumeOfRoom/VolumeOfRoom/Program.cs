using System;

namespace VolumeOfRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght, width, height, volume;

            Console.Write("Enter the lenght of room: ");
            lenght = double.Parse(Console.ReadLine());
            Console.Write("ENter the width of room: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Enter the height of room: ");
            height = double.Parse(Console.ReadLine());

            volume = lenght * width * height;

            Console.Clear();

            Console.WriteLine("The lenght of room is {0}", lenght);
            Console.WriteLine("The width of room is {0}", width);
            Console.WriteLine("The height of room is {0}", height);
            Console.WriteLine("The volume of room is {0}", volume);

            Console.ReadLine();
        }
    }
}
