using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {

        public static void Main(string[] args)
        {

            // calling the 4 methods

            //1st
            methods mt = new methods();
            mt.sum();

            //2nd
            double r = mt.addition();
            Console.WriteLine("the output for 2nd method is :"+ r);


            //3rd
            mt.subtraction(300,301);

            //4th
            double z = mt.subt(400, 401);
            Console.WriteLine("the output for 4th method is :" + z);



        }
    }
}
