using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputDataFromUser
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List <String> username = new List <string>();
            start:
            Console.Write("\nEnter the username: ");
            username.Add(Console.ReadLine());

            Console.Write("Do you want to write again (y/n): ");
            Char ch = char.Parse(Console.ReadLine());
            if (ch == 'y' || ch == 'Y')
            {
                goto start;
            }

            Console.WriteLine("\n");
            for (int i = 0; i < username.Count; i++)
            {
                Console.WriteLine("{0}.{1}", i + 1, username[i]);
            }

            Console.ReadLine();
        }
    }
}
