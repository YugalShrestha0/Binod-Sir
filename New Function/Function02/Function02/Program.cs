        
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function02
{
    class Program
    {
        static int add()
        {
            int first, second;

            Console.Write("Enter the first number: ");
            first = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number: ");
            second = int.Parse(Console.ReadLine());

            int Sum = first + second;
            return Sum;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nThe sum is {0}",add());
            Console.ReadLine();

        }
    }
}
