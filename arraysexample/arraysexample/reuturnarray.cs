using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysexample
{
    class reuturnarray
    {

        public double[] circle()
        {
            Console.Write("Enter the radius of the circle: ");
            double r = double.Parse(Console.ReadLine());

            //area
            double area = 3.14 * r * r;
            double circum = 2 * 3.14 * r;

            //returning the array
            double[] result = new double[2] { area, circum };
            return result;
        }

        public static void Main()
        {
            reuturnarray obj = new reuturnarray();
            double [] a =obj.circle();
            Console.WriteLine("The area of the circle is: " + a[0]);
            Console.WriteLine("The circumference if the circle is: " + a[1]);
        }
    }
}
