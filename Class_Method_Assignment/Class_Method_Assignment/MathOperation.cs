using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    class MathOperation
    {
        public static void Output(int Num1, int Divisor, out int Result)
        {
           
            Result = Num1 / Divisor;
            
  
        }

        public static void Output2(int Num1, int Divisor, int Num2, out int Result2)
        {
            
            Result2 = (Num1 + Num2) / Divisor;

        }


    }

}
