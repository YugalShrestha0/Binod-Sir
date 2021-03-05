using System;

namespace Read_2_number_and_find_diff_and_product
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, Diff, Product;
            Console.Write("\nEnter a first number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter a second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Diff = n1 - n2;
            Product = n1 * n2;
            Console.Clear();
            Console.WriteLine("First Number: {0}", n1);
            Console.WriteLine("Second Number: {0}", n2);
            Console.WriteLine("Diference is: {0}", Diff);
            Console.WriteLine("Product is: {0}", Product);
            Console.ReadLine();
        }
    }
}
