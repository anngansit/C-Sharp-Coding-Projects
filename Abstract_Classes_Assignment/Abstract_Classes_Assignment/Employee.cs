using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    class Employee : Person
    {
        public new void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.ReadLine();
        }


    }
}
