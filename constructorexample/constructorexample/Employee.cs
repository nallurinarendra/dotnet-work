using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorexample
{
    class Employee
    {

        int eno;
        string ename;
        double salary;
        //creating the default constructor
        public Employee()
        {
            Console.WriteLine("Default constructor");
            eno = 100;
            ename = "Narendra";
            salary = 5685;
        }

        //Argument constructor
        public Employee(int Eno, string Ename, double Esalary)
        {
            eno = Eno;
            ename = Ename;
            salary = Esalary;
        }

        //copy constructor
        public Employee(Employee obj)
        {
            eno = obj.eno;
            ename = obj.ename;
            salary = obj.salary;
        }

        public void  PrintDetails()
        {
            Console.WriteLine("The details of the Employee");
            Console.WriteLine("================================");
            Console.WriteLine("Employee number : " + eno);
            Console.WriteLine("Employee name : " + ename);
            Console.WriteLine("Employee salary : " + salary);

        }


        public static void Main()
        {
            Employee obj1 = new Employee();
            Employee obj2 = new Employee(111, "Mahesh", 5684);
            Employee obj3 = new Employee(obj1);
            Employee obj4 = new Employee(obj2);


            obj1.PrintDetails();
            obj2.PrintDetails();
            obj3.PrintDetails();
            obj4.PrintDetails();


        }

    }
}
