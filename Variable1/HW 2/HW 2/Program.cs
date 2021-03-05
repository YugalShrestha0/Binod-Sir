using System;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String Food;
            Console.Write("Enter your favouritr food: ");
            Food = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Favourite Food: {0}", Food);
            Console.ReadLine();
        }
    }
}
