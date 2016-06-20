using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysexample
{
    class singledimensional
    {
        static void Main(string[] args)
        {

            //declaring the array

            double[] a = new double[5];

            //storing the values into array manual method


            a[0] = 4;
            a[1] = 5;
            a[2] = 5;
            a[3] = 6;
            a[4] = 8;
            //display the values
            Console.WriteLine("the values stored in the array: " );
            Console.WriteLine("a[0]: " + a[0]);
            Console.WriteLine("a[1]: " + a[1]);
            Console.WriteLine("a[2]: " + a[2]);
            Console.WriteLine("a[3]: " + a[3]);
            Console.WriteLine("a[4]: " + a[4]);

            //if there are so many values we have to use for loop

            Console.WriteLine("Enter the values to be stored in array:");
            for (int i =0; i<a.Length; i++)
            {
                a[i] = double.Parse(Console.ReadLine());
            }

            // displaying using for loop

            for (int i = 0; i< a.Length; i++)
            {
                Console.WriteLine("The value stored in " + "a["+i+"] is : "+ a[i] );
            }


        }
    }
}
