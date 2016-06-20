using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collectionsexample
{
    class HashSetExample
    {
        public static void Main()
        {
            //initialize the hash set
            HashSet < string > obj = new HashSet<string>();

            //add values to the Hashset

            obj.Add("Narendra");
            obj.Add("Rana");
            obj.Add("Mahesh");

            //display 
            Console.WriteLine("The values in the HASH SET: ");
            foreach(string n in obj)
            {
                Console.WriteLine(n);
            }


        }
    }
}
