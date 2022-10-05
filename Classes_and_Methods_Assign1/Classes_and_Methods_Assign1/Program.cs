using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assign1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter first number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int y = Convert.ToInt32(Console.ReadLine());

            int Sum = Math_Operators.Add(x, y);
            int Difference = Math_Operators.Subtract(x ,y);
            Decimal Product = Math_Operators.Multiply(x, y);
            Double Quotient = Math_Operators.Divide(x, y);


            string msg1 = "The sum is: " + Convert.ToInt32(Sum);
            string msg2 = "The difference is: " + Convert.ToInt32(Difference);
            string msg3 = "The product is: " + Convert.ToDecimal(Product);
            string msg4 = "The quotient is: " + Convert.ToDouble(Quotient);


            Console.WriteLine(msg1);
            Console.WriteLine(msg2);
            Console.WriteLine(msg3);
            Console.WriteLine(msg4);

     
            Console.ReadLine();

        }
    }
}
