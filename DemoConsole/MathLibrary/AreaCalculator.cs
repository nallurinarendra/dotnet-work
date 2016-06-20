using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class AreaCalculator
    {
        public string CalculatorName = "AreaCalculator";
        public double Area(int side)
        {
            Console.WriteLine("Calculated by : " + CalculatorName);
            return side * side;

        }
        public double Area(double len, double breadth)
        {
            Console.WriteLine("Calculated by : " + CalculatorName);
            return len * breadth;

        }
    }
}
