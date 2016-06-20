using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collectionsexample
{
    class arraylistexample
    {
        static void Main(string[] args)
        {
            //declaring array list 
            ArrayList a = new ArrayList();

            a.Add("Narendra");
            a.Add(1000);
            a.Add('n');

            //display the array list
            foreach(dynamic n in a)
            {
                Console.WriteLine(n);
            }

        }
    }
}
