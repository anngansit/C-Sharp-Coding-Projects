using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    class MathOperation
    {
        public int X { get; set; }
        public int Y { get; set; }
        
        public void Divide()
        {
            Console.WriteLine(Divide(X, Y));
            Console.ReadLine();

                  }

        public static Double Divide(int X, int Y)
        {
           
            Double Quotient = X / Y;
            return Quotient;

        }
    }
}
