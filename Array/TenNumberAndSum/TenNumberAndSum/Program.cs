using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenNumberAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int sum = 0;

            for (int i = 0; i < 10; i++) 
            {
                Console.Write("\nEnter the number: ");
                num[i] = int.Parse(Console.ReadLine());
                sum += num[i];
            }
            Console.Clear();

            Console.WriteLine("----------ENTERED NUMBER----------");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\n\t\t{0}", num[i]);
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("\nThe sum is: {0}", sum);

            Console.ReadLine();
        }
    }
}
