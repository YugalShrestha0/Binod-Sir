using System;

namespace VariableAndDataType_3_ParseMethod_
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, Quotient;
            Console.Write("\nEnter first number: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("\nEnter second number:");
            b = double.Parse(Console.ReadLine());
            Quotient = a / b;
            Console.Clear();
            Console.WriteLine("Quotient of {0} and {1} is {2}", a, b, Quotient);
            Console.ReadLine();
        }
    }
}
