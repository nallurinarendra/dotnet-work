using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApplication
{
    class Demo1
    {

        //polymorphism
        public static void Main()
        {
            student st;
            //st is a reference variable of type student
            //st can refer to any student object or its derived types
             

            st = new student { FirstName = "Albert", LastName = "Einstein" };
            st.PrintDetails(); //it is calling base class method

            st = new graduatestudent { FirstName = "albert", LastName = "einstein" };
             st.PrintDetails(); //it is calling derived class

        }


    }
}
