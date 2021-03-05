using System;

namespace ReadHeightAndRadiusOfCircleAndCalculateTSACSAandVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, h, TSA, CSA, Volume;
            double PI = Math.PI;
            Console.Write("\nEnter the radius of the circle: ");
            r = double.Parse(Console.ReadLine());
            Console.Write("\nEnter the height os the circle: ");
            h = double.Parse(Console.ReadLine());
            TSA = 2 * PI * r * (r + h);
            CSA = 2 * PI * r * h;
            Volume = PI * r * r * h;
            Console.Clear();
            Console.WriteLine("Radius and Height of circle is {0}, {1}", r, h);
            Console.WriteLine("TSA of circle: {0}", TSA);
            Console.WriteLine("CSA of circle: {0}", CSA);
            Console.WriteLine("Volume of th circle: {0}", Volume);
            Console.ReadLine();
        }
    }
}
