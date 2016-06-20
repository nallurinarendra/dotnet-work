using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApplication
{
    class student
    {
        //encapsulation 
        public int StudentId;
        public string FirstName;
        public string LastName;
        public double Total;
        public bool IsHosteler;

        private string _password;
        private double _mass;
        private string _encryptionkey;

        //Automatic properties
        public string HostelName { get; set; }


        //properties

        public double weight
        {
            get
            {
                Console.WriteLine("someone retrieved the weight...");
                return _mass * 9.8;
            }
            set
            {
                Console.WriteLine("someone set the weight...");
                _mass = value / 9.8;
            }
        }

        //write-only properties
        public string password
        {

            set

            {
                Console.WriteLine("some one set the password");
                _encryptionkey = value;

            }

        
        }


        //read only property
        public string Encryptiokey
        {
            get
            {
                return _encryptionkey;

            }
        }



        //constructors
        public student()
        {
            Console.WriteLine("A student object is created");
            Total = 0;
            IsHosteler = false;
        }

        public student(int studentId, string firstname, string lastname, double total, bool ishosteler)
        {
            Console.WriteLine("A student object as been created..");

            StudentId = studentId;
            FirstName = firstname;
            LastName = lastname;
            Total = total;
            IsHosteler = ishosteler;



        }

        //methods
        public virtual void PrintDetails()
        {

            Console.WriteLine("student details: ");
            Console.WriteLine(FirstName + " " + LastName);
            if (IsHosteler == true)
            {
                Console.WriteLine("stays in Hostel");
            }
            else
            {
                Console.WriteLine("Is a dayboarder");
            }
        }

        public double CalcAverage(int NumSubjects)
        {
            double average;
            average = Total / NumSubjects;

            return average;
        }

        public double CalcAverage(double revisedTotal, int numSubjects, string examName = "Internal") 
        {
            Console.WriteLine("Average Score in " + examName);
            double average;
            average = revisedTotal / numSubjects;
            return average;
        }

        
    }
    class graduatestudent : student
    {
        public int Yearofpassing;
        public string coursename;

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("year of passing1: " + Yearofpassing);


        }

        public void printCertificte()
        {
            PrintDetails();
            Console.WriteLine("Year of passing : " + Yearofpassing);
            Console.WriteLine("Course Name is :" + coursename);

        }

    }

    class Doctaratestudent : graduatestudent
    {
        public string Thesis;
        public string ProffesorName;
    }
}
