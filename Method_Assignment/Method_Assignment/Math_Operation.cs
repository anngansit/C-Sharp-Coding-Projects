using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    public class Math_Operation
    {
        public static int Add(int x, int y)
        {
            int Num1 = x;
            int Num2 = y;
            int Sum = Num1 + Num2;
            return Sum;

        }

        public static int Subtract(int x, int y)
        {
            int Num1 = x;
            int Num2 = y;
            int Difference = Num1 - Num2;
            return Difference;

        }

        public static Decimal Multiply(int x, int y)
        {
            int Num1 = x;
            int Num2 = y;
            Decimal Product = Num1 * Num2;
            return Product;

        }

        public static Double Divide(int x, int y)
        {
            int Num1 = x;
            int Num2 = y;
            Double Quotient = (Double)Num1 / (Double)Num2;
            return Quotient;
        }
    }

}


