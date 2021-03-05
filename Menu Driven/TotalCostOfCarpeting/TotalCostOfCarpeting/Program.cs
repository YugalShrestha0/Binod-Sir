using System;

namespace TotalCostOfCarpeting
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght, RatePerSquareMeter, TotalCost;

            Console.Write("Enter the lenght of carpet in meter: ");
            lenght = double.Parse(Console.ReadLine());
            Console.Write("Enter the Rate Per Square Meter: ");
            RatePerSquareMeter = double.Parse(Console.ReadLine());

            TotalCost = lenght * RatePerSquareMeter;

            Console.Clear();

            Console.WriteLine("The Lenght of Carpet is {0}", lenght);
            Console.WriteLine("Rate per Square meter: {0}", RatePerSquareMeter);
            Console.WriteLine("Total Cost: {0}", TotalCost);

            Console.ReadLine();
        }
    }
}
