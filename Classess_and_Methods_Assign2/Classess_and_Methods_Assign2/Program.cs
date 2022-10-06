using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classess_and_Methods_Assign2
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOp mathOp = new MathOp();

            int y = 10;
            int Result;

            Console.WriteLine("Enter an integer:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The second integer is: " + y);

            Result = MathOp.Output(x, y);
            
            Console.WriteLine("The sum of the 2 numbers is: " + Result);
            Console.ReadLine();
        } 
    }
}
