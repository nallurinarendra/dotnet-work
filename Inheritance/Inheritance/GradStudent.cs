using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class GradStudent : student
    {

        public string MasterDegree;
        public string University;
        public double GPA;


        public void GGetDetails()

        {
            Console.WriteLine("Enter the MasterDegree: ");
            MasterDegree = string.Format(Console.ReadLine());
            Console.WriteLine("Enter the University: ");
            University = string.Format(Console.ReadLine());
            Console.WriteLine("Enter the GPA: ");
            GPA = double.Parse(Console.ReadLine());
        }

        public void GPrintDetails()

        {
            Console.WriteLine(" MasterDegree is: " + MasterDegree);
            Console.WriteLine("University is : " + University);
            Console.WriteLine("MasterDegreeis : "+ GPA);
            
        }
    }
}
