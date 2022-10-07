using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee();
            emp1.FirstName = "Analiza";
            emp1.LastName = "Gansit";
            emp1.Id = 1001;

            Employee emp2 = new Employee();
            emp2.FirstName = "Sample";
            emp2.LastName = "Employee";
            emp2.Id = 1002;

            if (emp1.Id == emp2.Id)
            {
                Console.WriteLine("Employee1 is equal to Employee2");
            }
            else
            {
                Console.WriteLine("Employee1 is not equal to Employee2");
            }

            Console.ReadLine();
        }
    }
}
