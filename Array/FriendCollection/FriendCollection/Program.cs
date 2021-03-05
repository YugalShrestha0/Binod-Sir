using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friend = new string[20];

            for (int i=0;i<=6;i++)
            {
                Console.Write("Enter the friend name: ");
                friend[i] = Console.ReadLine();
            }
            Console.Clear();

            Console.WriteLine("-----------Your Friend list---------");
            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine(friend[i]);
            }

            Console.ReadLine();
        }
    }
}
