using System;

namespace Variable_Example_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, Sum;
            Console.Write("\nEnter a first number:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter a second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Sum = n1 + n2;
            Console.Clear();
            Console.WriteLine("First number: {0}", n1);
            Console.WriteLine("Second number: {0}", n2);
            Console.WriteLine("Sum is: {0}", Sum);
            Console.ReadLine();
        }
    }
}
