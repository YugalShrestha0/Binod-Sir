using System;
using System.Runtime.ConstrainedExecution;

namespace DiscountMart
{
    class Program
    {
        static void Main(string[] args)
        {
            double PurchaseAmount, Discount, DiscountedAmount;
            Console.Write("Enter the Amount: ");
            PurchaseAmount = double.Parse(Console.ReadLine());

            if(PurchaseAmount >= 10000 && PurchaseAmount <= 50000)
            {
                Discount = 0.05 * PurchaseAmount;
            }
            else if(PurchaseAmount >= 50000 && PurchaseAmount <= 200000)
            {
                Discount = 0.1 * PurchaseAmount;
            }
            else if(PurchaseAmount >= 200000 && PurchaseAmount <= 500000)
            {
                Discount = 0.15 * PurchaseAmount;
            }
            else
            {
                Discount = 0.2 * PurchaseAmount;
            }

            Console.Clear();

            Double Amount = PurchaseAmount - Discount;
            Console.WriteLine("Purchase Amount: {0}", PurchaseAmount);
            Console.WriteLine("Discount: {0}", Discount);
            Console.WriteLine("Total Amount: {0}", Amount);

            Console.ReadLine();
        }
    }
}
