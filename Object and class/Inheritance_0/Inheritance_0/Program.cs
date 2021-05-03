using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_0
{
    class geometry
    {
        public Double l, b, h, r;

        public void setValues()
        {
            Console.Write("Enter the lenght: ");
            l = double.Parse(Console.ReadLine());
            Console.Write("Enter the breadth: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter the height: ");
            h = double.Parse(Console.ReadLine());
        }

        public void getRadius()
        {
            Console.Write("Enter the Radius of circle: ");
            r = double.Parse(Console.ReadLine());
        }
    }

    class cuboid : geometry /*cuboid is child class and it is inheritance with geometry class and we can use all the things from geometry casss using public */
    {
        public void cuboidArea()
        {
            double cubArea = 2 * l * (l * b + b * h + l * h);
            Console.WriteLine("The area of cuboid is {0}", cubArea);
        }

        public void volume()
        {
            double vol = l * b * h;
            Console.WriteLine("The volime of cuboid is {0}", vol);
        }
    }

    class circle
    {
        public void area()
        {
            double cirArea = Math.PI * Math.Pow(r, 2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
