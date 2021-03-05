using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10NumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int sum = 0;
            double Average;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("\n{0}. Enter the Number: ", i+1);
                num[i] = int.Parse(Console.ReadLine());
                sum += num[i];
            }
            Console.Clear();

            Console.WriteLine("------------ENTERED NUMBER-----------");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\n\t\t{0}", num[i]);
            }
            Average = sum / 10;

            Console.WriteLine("\n------------ENTERED NUMBER-----------");
            Console.WriteLine("The Sum is: {0}", sum);
            Console.WriteLine("The Average is: {0}", Average);

            Console.ReadLine();
        }
    }
}
