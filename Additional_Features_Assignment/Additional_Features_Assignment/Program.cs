using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string busName = "Stylized Photobooth";

            Console.WriteLine("Welcome to {0}!\n", busName);

            RentalDetails RD1 = new RentalDetails("Birthday", 3, "pink");

            RD1.Rent();


            Console.ReadLine();
        }
    }
}
