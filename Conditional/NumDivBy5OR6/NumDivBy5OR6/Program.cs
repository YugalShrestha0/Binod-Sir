using System;

namespace NumDivBy5OR6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Whether the number is divisible by 5 or 6

            int a;
            Console.Write("Enter the Number: ");
            a = int.Parse(Console.ReadLine());

            if(a % 5 == 0 || a % 6 == 0)
            {
                Console.WriteLine("{0} is divisible by 5 or 6", a);
            }
            else
            {
                Console.WriteLine("{0} is neither divisible by 5 nor divisible by 6", a);
            }

            Console.ReadLine();
        }
    }
}
