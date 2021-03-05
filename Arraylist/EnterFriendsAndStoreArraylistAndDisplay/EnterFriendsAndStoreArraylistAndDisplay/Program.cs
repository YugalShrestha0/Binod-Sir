using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EnterFriendsAndStoreArraylistAndDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList friend = new ArrayList();
        label:

            Console.Write("\nEnter the friend name: ");
            friend.Add(Console.ReadLine());
            Console.Write("\nAny more friends?? y/n: ");
            char ch = char.Parse(Console.ReadLine());

            if (ch == 'y')
            {
                goto label;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("NAMES OF YOUR FRIEND\n");
                for (int i = 0; i < friend.Count; i++)
                {
                    Console.WriteLine("{0}. {1}", i + 1, friend[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
