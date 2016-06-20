using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collectionsexample
{
    class stackexample
    {
        public static void Main()
        {
            //creating the stack
            Stack obj = new Stack();

            //insert the values
            obj.Push("Narendra");
            obj.Push(1000);
            obj.Push('N');
            obj.Push(25.24);

            //display the values

            foreach (dynamic n in obj)
            {
                Console.WriteLine(n);

            }

            //removing the values

            obj.Pop();

            Console.WriteLine("values in stack after removing the values:");


            foreach (dynamic n in obj)
            {
                Console.WriteLine(n);

            }
        }
    }
}

