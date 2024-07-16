using percentageCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangePercentForUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name >>>");
            string nn = Console.ReadLine();

            Console.WriteLine("Please enter the student mark>>");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the percent (%) to increase the result by >>");
            double y = Convert.ToDouble(Console.ReadLine());

            //exception handling 
            // Check if the inputs are valid
            if (x < 0 || y < 0 || y > 100)
            {
                throw new ArgumentException("Invalid input");
            }

            //using the ddl 
            Class1 cc = new Class1();
            cc.percent(x, y);

            Console.WriteLine("The new results for " + nn + cc);
        }
    }
}
