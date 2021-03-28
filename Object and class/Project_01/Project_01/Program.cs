using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01
{
    class SectionC
    {
        public int CRN;
        public string batch, name, address;
    }

    class Program
    {
        static void Main(string[] args)
        {
            SectionC yugal = new SectionC();
            yugal.CRN = 50;
            yugal.batch = "007";
            yugal.name = "Yugal Kumar Shrestha";
            yugal.address = "Bharatpur";

            SectionC JohnCena = new SectionC();
            JohnCena.CRN = 500;
            JohnCena.batch = "001";
            JohnCena.name = "John Cena";
            JohnCena.address = "United State of America";

            Console.WriteLine("---------YUGAL DETAILS----------");
            Console.WriteLine("Name:    {0}", yugal.name);
            Console.WriteLine("Address: {0}", yugal.address);
            Console.WriteLine("CRN:     {0}", yugal.CRN);
            Console.WriteLine("Batch:   {0}", yugal.batch);

            Console.ReadLine();
        }
    }
}
