using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace DemoConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an object of type student
            student st = new student();
            st.StudentId = 1;
            st.FirstName = "Narendra";
            st.LastName = "Nalluri";
            st.IsHosteler = false;
            st.Total = 500;

            st.PrintDetails();
            Console.WriteLine("Average: " + st.CalcAverage(6));
            Console.WriteLine("Revised total: " + st.CalcAverage(678, 6));




            student st2 = new student();

            st2.StudentId = 2;
            st2.FirstName = "Nani";
            st2.LastName = "Edupuganti";
            st2.IsHosteler = true;
            st2.Total = 455;
            st2.PrintDetails();
            Console.WriteLine("Average: " + st2.CalcAverage(6));



            student st3 = new student(100, "henry", "reo", 522, false);


            //object initializer syntax
            student st4 = new student
            {
                FirstName = "albert",
                LastName = "Einstein",
            };

            graduatestudent gst = new graduatestudent
            {
                StudentId = 120,
                FirstName = "Praveen",
                LastName = "M",

                Yearofpassing = 2014,
                coursename = "English"
            };
            gst.printCertificte();

            //using .dll file here
            AreaCalculator calc = new AreaCalculator();
            Console.WriteLine(calc.Area(20, 30)); 
            Console.WriteLine(calc.CalculatorName);


            //set
            st4.weight = 100;
            //get 
            Console.WriteLine(st4.weight);

           
            //Console.WriteLine(st4.password);
        }

    }
}
