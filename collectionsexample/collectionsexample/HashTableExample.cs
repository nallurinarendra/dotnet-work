using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collectionsexample
{
    class HashTableExample
    {
        public static void Main()
        {
            //initialize the Hash Table

            Hashtable obj = new Hashtable();

            //insert values into Hash Table

            obj.Add(100, "Narendra");
            obj.Add(155, 147);
            obj.Add(156, 'N');
            obj.Add(148, 152.32);

            //displaying 
            foreach(int n in obj.Keys)
            {
                Console.WriteLine("key: " + n + ",value: " + obj[n].ToString());
            }
        }
    }
}
