using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3NumAndReturnValue
{
 
    class Program
    {
         static  int a, b, c;
        public static int mathematical()
        {
       Console.Write("Enter the first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            c = int.Parse(Console.ReadLine());

            int product = a * b * c;
            return product;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(a);
            Console.WriteLine("\nThe product of {0} is {1}",a, mathematical());
            Console.ReadLine();
        }
    }
}
