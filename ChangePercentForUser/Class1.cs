using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace percentageCalculator
{
    public class Class1
    {
        //a method that recieve two numbers the mark

        public double percent(double x, double y )
        {
            // Check if the inputs are valid
          /*  if (x < 0 || y < 0 || y > 100)
            {
                throw new ArgumentException("Invalid input");
            }
          */
            // Calculate the percentage using the formula
            double result = (x / 100.0) * y;

            // Return the result that the user expects 
            return result;

            
        }
    }
}
