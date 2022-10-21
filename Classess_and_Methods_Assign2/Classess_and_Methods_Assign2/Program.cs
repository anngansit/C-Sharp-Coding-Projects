using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classess_and_Methods_Assign2
{
    class Program
    {
        public static void Main(string[] args)
        {
            MathOp mathOp = new MathOp();

            
            Console.WriteLine("Enter first number:");
            int FN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number.  This is optional. You may not enter anything.");
            string SN = Console.ReadLine();

            MathOp.ADDNumbers(FN, SN);
            Console.ReadLine();
        }

    }
    
 } 
    
