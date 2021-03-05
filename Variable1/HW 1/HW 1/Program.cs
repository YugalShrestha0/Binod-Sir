using System;

namespace HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend1, friend2, friend3, friend4;
            Console.Write("\nEnter first freind name: ");
            friend1 = Console.ReadLine();
            Console.Write("\nEnter second friend name: ");
            friend2 = Console.ReadLine();
            Console.Write("\nEnter third friend name: ");
            friend3 = Console.ReadLine();
            Console.Write("\nEnter fourth friend name: ");
            friend4 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("First Friend: {0}", friend1);
            Console.WriteLine("Second Friend: {0}", friend2);
            Console.WriteLine("Third Friend: {0}", friend3);
            Console.WriteLine("Fourth Friend: {0}", friend4);
            Console.ReadLine();
        }
    }
}
