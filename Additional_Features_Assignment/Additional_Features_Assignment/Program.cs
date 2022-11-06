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
            
            Console.WriteLine("What is your name?");
            var Name = Console.ReadLine();

            Console.WriteLine("Hello {0}. Welcome to {1}!", Name, busName );
            
            Console.ReadLine();
        }
    }
}
