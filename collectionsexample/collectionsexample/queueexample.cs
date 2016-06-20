using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collectionsexample
{
    class queueexample
    {
        public static void Main()
        {
            //initialize the queue
            Queue obj = new Queue();

            //insert the values
            obj.Enqueue("Mahesh");
            obj.Enqueue(150);
            obj.Enqueue('N');
            obj.Enqueue(152.25);

            //display the values

            foreach(dynamic n in obj)
            {
                Console.WriteLine(n);
            }

            //removing the values from queue

            obj.Dequeue();

            //displaying output after remobing values

            Console.WriteLine("the values after removing some data");
            foreach (dynamic n in obj)
            {
                Console.WriteLine(n);
            }
        }
    }
}
