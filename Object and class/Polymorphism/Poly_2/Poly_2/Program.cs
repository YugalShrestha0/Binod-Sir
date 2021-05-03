using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly_2
{
    class math
    {
        public void product()
        {
            int a, b;
            
            Console.Write("Enter the first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            b = int.Parse(Console.ReadLine());
            int mul = a * b;

            Console.WriteLine("the product of {0} and {1} is {2}", a, b, mul);
        }

        public void product(int x, int y)
        {
            int mul = x * y;
            Console.WriteLine("the product of the numbers is {0}", mul);
        }

        public void product(int x, int y, int z)
        {
            int mul = x * y * z;
            Console.WriteLine("the product of the numbers is {0}", mul);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            math m = new math();

            m.product();
            m.product(93, 6);
            m.product(89, 5, 63);

            Console.ReadLine();
        }
    }
}
