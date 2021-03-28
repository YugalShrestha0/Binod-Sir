using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_02
{
    class Chocolate
    {
        public int weight, price;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Chocolate dark = new Chocolate();
            dark.weight = 350;
            dark.price = 500;

            Console.WriteLine("The price of {0} gm of chocolate is {1}", dark.weight, dark.price);

            Console.ReadLine();

        }
    }
}
