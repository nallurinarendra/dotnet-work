using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class student
    {
       
        public int sNo;
        public string sName;
        public Double Total;
     
        public void GetDetails()
        {
            Console.WriteLine("Enter the Student Number");
            sNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Student Name");
            sName = string.Format(Console.ReadLine());
            Console.WriteLine("Enter the Student Total");
            Total = double.Parse(Console.ReadLine());
        }
        public void PrintDetails()
        {
            Console.WriteLine("the Student Number is: "+ sNo);
            Console.WriteLine("the Student Name is: "+ sName);
            Console.WriteLine("the Student Total is: "+ Total);
        }
    }
}
