using System;

namespace VariableAndDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, Difference;
            Console.Write("\nEnter first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("\nEnter second number: ");
            b = int.Parse(Console.ReadLine());
            Difference = a - b;
            Console.Clear();
            Console.WriteLine("First number: {0}", a);
            Console.WriteLine("Second Number: {0}", b);
            Console.WriteLine("Difference is: {0}", Difference);
            Console.ReadLine();
        }
    }
}
