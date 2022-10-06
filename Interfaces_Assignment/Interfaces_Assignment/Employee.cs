using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Assignment
{
    class Employee : Person, IQuittable
    {
        public new void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
           
        }
        public void Quit()
        {
            Console.WriteLine("Employee " + firstName + " " + lastName + " is leaving the company.");
            Console.ReadLine();
        }
    }
}
