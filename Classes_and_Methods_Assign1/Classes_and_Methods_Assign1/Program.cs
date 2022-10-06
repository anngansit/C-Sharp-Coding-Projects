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
            Math_Operators math_Operators = new Math_Operators();

            
          
            Console.WriteLine("Enter first number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int y = Convert.ToInt32(Console.ReadLine());

            int Product = Math_Operators.Objects(x, y);
            Console.WriteLine("The product is: " + Product);
            Console.ReadLine();

            Console.WriteLine("\nEnter third number:");
            Decimal a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fourth number:");
            Decimal b = Convert.ToInt32(Console.ReadLine());

            Decimal Diff = Math_Operators.Objects(a, b);
            Console.WriteLine("The difference is: " + Diff);
            Console.ReadLine();

            
            Console.WriteLine("\nEnter fifth number:");
            string c = Console.ReadLine();
            int C = Convert.ToInt32(c);
            Console.WriteLine("Enter sixth number:");
            string d = Console.ReadLine();
            int D = Convert.ToInt32(d);
            int Sum = Math_Operators.Objects(C, D);
            Console.WriteLine("The sum is: " + Sum);
            Console.ReadLine();



        }
    }
}
