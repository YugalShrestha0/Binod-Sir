using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2NumAndDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            Diff();
            Console.ReadLine();
        }

        static void Diff()
        {
            int a, b;

            Console.Write("Enter the first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            b = int.Parse(Console.ReadLine());

            double Difference = a - b;

            Console.WriteLine("\nThe Difference of {0} and {1} is {2}", a, b, Difference);
        }
    }
}
