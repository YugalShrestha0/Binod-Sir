using System;

namespace VariableAndDataType_2_ParseMethod_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, Multiplication;
            Console.Write("\nEnter first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("\nEnter Second number: ");
            b = int.Parse(Console.ReadLine());
            Multiplication = a * b;
            Console.Clear();
            Console.WriteLine("Multiplication of {0} and {1} is {2}", a, b, Multiplication);
            Console.ReadLine();
        }
    }
}
