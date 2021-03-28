using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class geometry
    {
        double lenght, breadth, height;
        double AreaOfSquare, AreaOfRectangle, AreaOfCuboid, VolumeOfCuboid;

        public void getValues()
        {
            Console.WriteLine("\n");
            Console.Write("Enter the lenght: ");
            lenght = double.Parse(Console.ReadLine());
            Console.Write("Enter the breadth: ");
            breadth = double.Parse(Console.ReadLine());
            Console.Write("Enter the height: ");
            height = double.Parse(Console.ReadLine());
        }

        public void area()
        {

            AreaOfSquare = lenght * lenght;
            AreaOfRectangle = lenght * breadth;
            AreaOfCuboid = 2 * (lenght * breadth + breadth * height + lenght * height);

            Console.WriteLine("The Area of Square is {0}.", AreaOfSquare);
            Console.WriteLine("The Area of Rectangle is {0}.", AreaOfRectangle);
            Console.WriteLine("The Area of Cuboid is {0}.", AreaOfCuboid);
        }

        public void Volume()
        {

            VolumeOfCuboid = lenght * breadth * height;

            Console.WriteLine("\nThe Volume of Cuboid is {0}.", VolumeOfCuboid);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            geometry geo = new geometry();
            geo.getValues();
            Console.Clear();
            geo.area();
            geo.Volume();

            Console.ReadLine();
        }
    }
}
