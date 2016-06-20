using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class methods
    {


        //1st method
        public void sum()
        {
            double x = 100;
            double y = 200;

            double z = x + y;
            Console.WriteLine("the output for 1st method is : " + z);

        }


        //2nd method
        public double addition()
        {
            double x = 200;
            double y = 201;
            double z = x + y;
            return z;
        }

        //3rd method
        public void subtraction(double a, double b)
        {
            double x = a;
            double y = b;
            double z = x- y;

            Console.WriteLine("the uutput for 3rd method is :"+ z);
        }

        //4th method
        public double subt(double a, double b)
        {
            double  x = a;
            double y = b;
            double z = x - y;

            return z;
        }
    }
}
