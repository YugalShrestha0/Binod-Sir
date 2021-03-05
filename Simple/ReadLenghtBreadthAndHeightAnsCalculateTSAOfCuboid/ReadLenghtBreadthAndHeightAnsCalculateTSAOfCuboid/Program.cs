using System;

namespace ReadLenghtBreadthAndHeightAnsCalculateTSAOfCuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght, breadth, height, TSA;
            Console.Write("\nEnter the lenght of Cuboid: ");
            lenght = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the breadth of Cuboid: ");
            breadth = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the height of Cuboid: ");
            height = int.Parse(Console.ReadLine());
            TSA = 2 * (lenght * breadth + lenght * height + breadth * height);
            Console.Clear();
            Console.WriteLine("Lenght, breadth and Height of the Cuboid is {0}, {1}, {2}", lenght, breadth, height);
            Console.WriteLine("TSA of the Cuboid: {0}", TSA);
            Console.ReadLine();
        }
    }
}
