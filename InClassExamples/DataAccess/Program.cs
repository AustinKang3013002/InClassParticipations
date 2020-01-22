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
            
            double num1 = 28;
            double num2 = 482.2;
            double num3 = 382.222;
            double result = Add(5, 17.5);
            Console.WriteLine($"5+17.5 = { result.ToString("N2")}");
            result = Add(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {result.ToString("N2")}");

            //double[] nums = { num1, num2, num3 };
            //nums = new double
            // nums[0] = num1;
            //  nums[1] = num2;
            // nums[2] = num3;
            //nums[3] = Error Out of Index;
            result = Add(nums);



            Console.ReadKey();



        }
        static double Add(double[] NumbersToAddUp)
        {
            double r = 0;
            int counter = 0;
            while (counter<NumbersToAddUp.Length)
            {
                var number = NumbersToAddUp[counter];
            }

            foreach (var number in NumbersToAddUp)
            {
                r += number;
            }
            for (counter = 0; counter < NumbersToAddUp.Length; counter++)
            {
                var number = NumbersToAddUp[counter];
                r += number;
            }
            return r;

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
