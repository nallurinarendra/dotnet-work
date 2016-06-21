using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class ClassA
    {
        public double r;
        public double l;
        public double b;

        public void Area( double r)
        {
            double area = 3.14 * r * r;
            Console.WriteLine("The area of the circle is: " + area);
        }
        public void Area(double l, double b)
        {
            double area = l * b;
            Console.WriteLine("The area of Reectangle is: " + area);
        }

    }
}
