using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList names = new ArrayList { "John", "Rock", "Salman", "Jack", "yugal" };
            names.Add("KP Oli");
            names.Add("Prachanda");
            names.Add("KP Ba");
            names.Add("Rame");
            Console.WriteLine("FRIENDS NAME\n");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, names[i]);
            }

            Console.ReadLine();

            names.Sort();
            Console.WriteLine("FRIENDS NAME IN ALPHABETIC ORDER\n");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, names[i]);
            }

            Console.ReadLine();

            names.Reverse();
            Console.WriteLine("FRIENDS NAME IN REVERSE\n");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, names[i]);
            }

            Console.ReadLine();
        }
    }
}
