using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseAndDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string[] name = new string[100];
            double[] rate = new double[100];
            double[] quantity = new double[100];
            double Amount, TotalAmount = 0, Discount, TotalAmountAfterDiscount;
            Console.Write("Enter the number of product purchased by the costumer: ");
            n = int.Parse(Console.ReadLine());
            Console.Clear();

            for(int i=0;i<n;i++)
            {
                Console.Write("\nEnter the product name: ");
                name[i] = Console.ReadLine();
                Console.Write("\nEnter the rate: ");
                rate[i] = Double.Parse(Console.ReadLine());
                Console.Write("\nEnter the quantity: ");
                quantity[i] = Double.Parse(Console.ReadLine());
            }
            Console.Clear();

            Console.WriteLine("-----------DETAIL OF THE PURCHASED PRODUCT-----------");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}","Product Name", "Rate", "Quantity", "Amount");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\t\t{1}\t{2}\t\t{3}", name[i], rate[i], quantity[i], Amount=rate[i]*quantity[i]);
                TotalAmount += Amount;
            }
            Console.WriteLine("\n------------------------------------------------");
            
            if(TotalAmount > 10000)
            {
                Discount = 0.1 * TotalAmount;
                TotalAmountAfterDiscount = TotalAmount - Discount;
                Console.WriteLine("Discount Amount: {0}", Discount);
                Console.WriteLine("Total amount after discount: {0}", TotalAmountAfterDiscount);
            }
            else
            {
                Console.Write("Total Amount: {0}", TotalAmount);
            }

            Console.ReadLine();
        }
    }
}
