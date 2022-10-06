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

            MathOperation math_operation = new MathOperation();

            int Num1, Divisor=2, Num2=4;
            int Result, Result2;
            

            Console.WriteLine("Enter a number:");
            Num1 = Convert.ToInt32(Console.ReadLine());

            MathOperation.Output(Num1, Divisor, out Result);
            MathOperation.Output2(Num1, Divisor, Num2, out Result2);

            Console.WriteLine("The output when divided by 2 is:  " +Result);
            Console.WriteLine("The output when added by 4 and sum divided by 2 is: " +Result2);

            Console.ReadLine();

           
        }

    }
}


