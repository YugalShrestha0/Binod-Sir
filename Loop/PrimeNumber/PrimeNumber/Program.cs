using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a=0;
            Console.Write("Enter the number: ");
            n = int.Parse(Console.ReadLine());

            for(int i=1;i<=n;i++)
            {
                if(n % i == 0)
                {
                    a++;
                }
            }
            if(a == 2)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Consotant Number");
            }

            Console.ReadLine();
        }
    }
}
