using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class MainClass
    {

        //
        public static void Main()
        {
            ClassA obj = new ClassA();

            obj.Area(4);
            obj.Area(3, 4);
        }

    }
}
