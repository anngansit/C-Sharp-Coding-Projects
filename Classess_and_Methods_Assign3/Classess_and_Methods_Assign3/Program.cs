using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classess_and_Methods_Assign3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int Num1 = 12; int Num2=24;
            Console.WriteLine("Enter first number:");
            Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            Num2 = Convert.ToInt32(Console.ReadLine());

            MyClass myclass = new MyClass();

           
            int Sum = myclass.Add(Num1, Num2);
            Console.WriteLine("The sum is: {0}", Sum);
            Console.ReadLine();

        }
    }
}
