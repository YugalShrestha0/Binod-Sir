using System;

namespace ReadThreeNumAndDisplayProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, product;
            Console.Write("\nEnter first number: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("\nEnter second number: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("\nEnter third number: ");
            z = int.Parse(Console.ReadLine());
            product = x * y * z;
            Console.Clear();
            Console.WriteLine("First, Second and Third number is: {0}, {1}, {2} ", x, y, z);
            Console.WriteLine("Product is {0}", product);
            Console.ReadLine();
        }
    }
}
