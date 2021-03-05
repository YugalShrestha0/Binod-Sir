using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            sum();
            Console.ReadLine();
        }

        static void sum()
        {
            int first, second;

            Console.Write("Enter the first number: ");
            first = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            second = int.Parse(Console.ReadLine());

            int sum = first + second;
            Console.WriteLine("The sum of" + first + "and" + second + "is {0}", sum);
        }
    }
}
