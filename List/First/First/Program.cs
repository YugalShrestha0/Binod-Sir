using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> student = new List<string>{"Bikal", "Abhinaw", "Sabita", "Supriya", "Upama", "Aakash", "Prashant", "Hari", "Ram", "Shyam", };

            student.Sort();
            for (int i = 0; i < student.Count; i++)
            {
                Console.WriteLine("{0}. {1}",i+1, student[i]);
            }

            Console.ReadLine();
        }
    }
}
