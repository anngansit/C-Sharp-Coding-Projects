using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter firt number:");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            int Sum = Math_Operation.Add(Num1, Num2);
            int Difference = Math_Operation.Subtract(Num1, Num2);
            Decimal Product = Math_Operation.Multiply(Num1, Num2);
            Double Quotient = Math_Operation.Divide(Num1, Num2);

            Console.WriteLine("The sum is: " + Sum);
            
            Console.WriteLine("The difference is: " + Difference);

            Console.WriteLine("The product is: " + Product);

            Console.WriteLine("The quotient is: " + Quotient);

            Console.ReadLine();
        }
        
    }
}
