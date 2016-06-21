using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {

            A_Class obj1 = new A_Class();
            B_Class obj2 = new B_Class();

            obj1.GetDetails();
            obj1.PrintDetails();
            obj2.GetDetails();
            obj2.PrintDetails();
        }
    }
}
