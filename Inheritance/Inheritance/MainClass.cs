using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class MainClass
    {

        public static void Main()
        {

            // getting the details for the grad student
            GradStudent obj = new GradStudent();
            obj.GetDetails();
            obj.GGetDetails();

            //printing hte grad student details

            obj.PrintDetails();
            obj.GPrintDetails();


        }

    }
}
