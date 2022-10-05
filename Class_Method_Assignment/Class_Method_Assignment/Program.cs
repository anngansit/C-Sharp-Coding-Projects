using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {

            int Y = 2;
            MathOperation mathoperation = new MathOperation();

            Console.WriteLine("Enter a number:");
            int X = Convert.ToInt32(Console.ReadLine());

           
            Double Quotient = MathOperation.Divide(X, Y);
            Double Remainder = MathOperation.Remainder(X, Y);
          
            Console.WriteLine("The number you entered is: " + X);
            Console.WriteLine("The number you entered divided by 2 is: " + Quotient);
            Console.WriteLine("Remainder: " + Remainder);
            Console.ReadLine();
        }
    }
}
