using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysexample
{
    class twodimensional
    {
        public static void Main()
        {
            //double dimensional array
            double[ , ] a;
            Console.Write("Enter the Row size: ");
            int rsize = int.Parse(Console.ReadLine());

            Console.Write("Enter the column size: ");
            int csize = int.Parse(Console.ReadLine());

            a = new double[rsize, csize];

            //stroing the values to the array
            Console.Write("Enter any " + rsize*csize + " values:");
            for (int i = 0; i< rsize; i++)
            {
                for (int j=0; j<csize; j++)
                {
                    a[i, j] = double.Parse(Console.ReadLine());
                }
            }

            //displaying the values
            Console.WriteLine("The values stored in the array:");
            for (int i = 0; i < rsize; i++)
            {
                for (int j = 0; j < csize; j++)
                {
                    Console.WriteLine("a["+i+","+j+"]: "+ a[i,j]);
                }
            } 
        }

    }
}
