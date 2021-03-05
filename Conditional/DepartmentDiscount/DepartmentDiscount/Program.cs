using System;

namespace DepartmentDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Double purchaseamount, discount;
            Console.Write("Enter the Purchase Amount: ");
            purchaseamount = Double.Parse(Console.ReadLine());

            if(purchaseamount < 1000)
            {
                discount = 0.01 * purchaseamount;
            }
            else if(purchaseamount >= 1000 && purchaseamount<10000)
            {
                discount = 0.05 * purchaseamount;
            }
            else if(purchaseamount >= 10000 && purchaseamount<50000)
            {
                discount = 0.1 * purchaseamount;
            }
            else
            {
                discount = 0.15 * purchaseamount;
            }

            Console.Clear();

            Double amount = purchaseamount - discount;
            Console.WriteLine("Purchase Amount={0} ", purchaseamount);
            Console.WriteLine("Discount Amount={0} ", discount);
            Console.WriteLine("Total Amount={0} ", amount);
            
            Console.Write("Do you want to Continue(y/n): ");
            Char Ch = Char.Parse(Console.ReadLine());
            
            if (Ch  == 'y' || Ch == 'Y')
            {
                goto start;
            }
            else
            {
                return;
            }
            
            Console.ReadLine();

        }
    }
}
