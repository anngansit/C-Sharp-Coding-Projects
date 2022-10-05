using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assign1
{
    class Math_Operators
    {
        public static int Add(int x, int y)
        {
            int Sum = x + y;
            return Sum;
        }

        public static int Subtract(int x, int y)
        {
           
            int Difference = x - y;
            return Difference;
        }

        public static Decimal Multiply(int x, int y)
        {

            Decimal Product = x * y;
            return Product;
        }

        public static Double Divide(int x, int y)
        {

            Double Quotient = x / y;
            return Quotient;
        }


    }
}
