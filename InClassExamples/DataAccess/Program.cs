// Austin Kang
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            double result= Add(5, 17.5);
            Console.WriteLine($"5+17.5 = { result.ToString("N2")}");
            Console.ReadKey();
            
            
        }
        /// <summary>
        /// sums up two numbers and provides the results 
        /// </summary>
        /// <param name="val1">Left hand operator</param>
        /// <param name="val2">Right hand operator</param>
        /// <returns>The sum of val1 and val2</returns>
        //method Add
        static double Add(double val1, double val2)
        {
            double sum = val1 + val2;
            return sum;
        }


    }
}
