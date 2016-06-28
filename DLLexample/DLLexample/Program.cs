using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathFunctionLibrary;

namespace DLLexample
{
    class Program
    {
        public static void Main()
        {
           double sum =  calc.Add(10, 20);
            Console.WriteLine("sum of two numbers is: " + sum);

            double sub = calc.sub(65, 45);
            Console.WriteLine("sum of two numbers is: " + sum);
            double div = calc.div(65, 45);
            Console.WriteLine("sum of two numbers is: " + div);
            double rem = calc.rem (65, 45);
            Console.WriteLine("sum of two numbers is: " + sum);
        




        }
        
    }
}
