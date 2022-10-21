using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {


            Employee<string> employee = new Employee<string>();

            List<string> ThingsList = new List<string>();
            ThingsList.Add("Pen");
            ThingsList.Add("Paper");
            ThingsList.Add("Tape");
               

            employee.Things = ThingsList;
           
            employee.DisplayThings();


            Employee<int> employee2 = new Employee<int>();

            List<int> ThingsList2 = new List<int>();
            ThingsList2.Add(10);
            ThingsList2.Add(20);
            ThingsList2.Add(30);
            ThingsList2.Add(50);



            employee2.Things = ThingsList2;

            employee2.DisplayThings();

            Console.ReadLine();
        }


    }
}
