using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classess_and_Methods_Assign2
{
    class MathOp
    {
        public static void ADDNumbers(int FirstNumber, string SecondNumber)
        {
            int FN = FirstNumber; string SN = SecondNumber; int result; int SecNum;

            bool b1 = string.IsNullOrEmpty(SN);

            if (b1)
            {
                Console.WriteLine("You did not enter any number.");
                result = FN;
            }
            else
            {
                SecNum = Convert.ToInt32(SN);
                result = FN + SecNum;
            }


            Console.WriteLine("Total = " + result);


        }


    }
}
