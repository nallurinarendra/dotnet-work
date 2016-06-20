using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysexample
{
    class jaggedarrays
    {
        public static void Main()
        {
            //double dimensional array
            double[][] a;
            Console.Write("Enter the Row size: ");
            int rsize = int.Parse(Console.ReadLine());

            //assign size to the array

            a = new double[rsize][];

            for (int i = 0; i< rsize; i++)
            {
                Console.WriteLine("Enter "+ i+" column size: ");
                int size = int.Parse(Console.ReadLine());
                a[i] = new double[size];
            }
            //stroing the values to the array
            Console.Write("Enter array values:");
            for (int i = 0; i < rsize; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = double.Parse(Console.ReadLine());
                }
            }

            //displaying the values
            Console.WriteLine("The values stored in the array:");
            for (int i = 0; i < rsize; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.WriteLine("a[" + i + "][" + j + "]: " + a[i][j]);
                }
                Console.WriteLine(" ");
            }
        }

    }
}
