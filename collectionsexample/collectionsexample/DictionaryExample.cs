using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collectionsexample
{
    class DictionaryExample
    {
        public static void Main()
        {
            Dictionary<double, int> obj = new Dictionary<double, int>();


            //adding values to the dictionary
            obj.Add(152.25, 15);
            obj.Add(142.25, 158);
            obj.Add(150, 154);

            //display the output
            //using the foreach Loop
            Console.WriteLine("display using the key value pair: ");
            foreach(KeyValuePair<double, int> n in obj)
            {
                Console.WriteLine("{0}, {1}", n.Key, n.Value);
            }

            //2nd method to display
            //using the var keyword
            Console.WriteLine("dispaly using the var:");
            foreach (var n in obj)
            {
                Console.WriteLine("{0}, {1}", n.Key, n.Value);
            }

         }
    }
}
