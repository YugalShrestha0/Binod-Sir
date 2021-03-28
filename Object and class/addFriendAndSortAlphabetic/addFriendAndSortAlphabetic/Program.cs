using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace addFriendAndSortAlphabetic
{
    class friends
    {
        int f;
        List<string> name = new List<string>();

        public void addFriends()
        {
            Console.Write("How many friends yo want to enter? ");
            f = int.Parse(Console.ReadLine());

            Console.Clear();

            for (int i = 0; i < f; i++)
            {
                Console.Write("{0}. Enter the friends name: ", i + 1);
                name.Add(Console.ReadLine());
            }

            Console.Clear();

            Console.WriteLine("----------FRIENDS NAME-----------");
            for (int i = 0; i < f; i++)
            {
                Console.WriteLine("\t{0}. {1}", i+1, name[i]);
            }

        }

        public void sortFriends()
        { 
            Console.WriteLine("\n----------ASCENDING ORDER-----------");

            name.Sort();
            for (int i = 0; i < f; i++)
            {
                Console.WriteLine("\t{0}. {1}", i + 1, name[i]);
            }

            Console.WriteLine("\n---------DESCENDING ORDER------------");

            name.Reverse();
            for (int i = 0; i < f; i++)
            {
                Console.WriteLine("\t{0}. {1}", i + 1, name[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            friends fri = new friends();
            fri.addFriends();
            fri.sortFriends();

            Console.ReadLine();
        }
    }
}
