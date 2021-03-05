using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing
{
    class Program
    {
        static void Main(string[] args)
        {
            int NProduct;
            double amount;
            double totalBillingAmount = 0;

            List<String> product = new List<string>();
            List<double> rate= new List<double>();
            List<double> quantity = new List<double>();

            Console.Write("Enter the number of product: ");
            NProduct = int.Parse(Console.ReadLine());

            Console.Clear();

            for (int i = 0; i < NProduct; i++)
            {
                Console.Write("\nEnter the Product: ");
                product.Add(Console.ReadLine());
                Console.Write("Enter the quantity: ");
                quantity.Add(double.Parse(Console.ReadLine()));
                Console.Write("Enter the rate: ");
                rate.Add(double.Parse(Console.ReadLine()));
            }

            Console.Clear();

            Console.WriteLine("-------------DETAIL OF PRODUCT-----------------");

            for (int i = 0; i < product.Count; i++)
            {
                amount = rate[i] * quantity[i];
                totalBillingAmount += amount;
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", i+1, product[i], rate[i], quantity[i], amount);
            }

            Console.WriteLine("\n----------TOTAL BILLING AMOUNT-----------");
            Console.WriteLine("Total Billing Amount is: {0}", totalBillingAmount);

            Console.ReadLine();


        }
    }
}
