using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("{0} is a even",num1);
            }
            else
            {
                Console.WriteLine("{0} is a odd", num1);
            }

            Console.ReadLine();
        }
    }
}
