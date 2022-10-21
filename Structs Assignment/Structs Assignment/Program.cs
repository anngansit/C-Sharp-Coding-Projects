using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_Assignment
{
    class Program
    {
        public static double PurchaseTax { get; private set; }

        static void Main(string[] args)
        {
            Number number = new Number();


            Console.WriteLine("Enter Amount:");
            number.Amount = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Your amount is: " + number.Amount);

            Console.ReadLine();

        }
    }
}
