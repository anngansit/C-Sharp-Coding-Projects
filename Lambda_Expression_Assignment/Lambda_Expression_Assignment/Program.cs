using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeList = new List<Employees>();


            var employee1 = new Employees()
            {
                FName = "Joe",
                LName = "Peters",
                EmpID =     1
            };

            var employee2 = new Employees()
            {
                FName = "Joe",
                LName = "Allen",
                EmpID = 2
            };

            var employee3 = new Employees()
            {
                FName = "Analiza",
                LName = "Gansit",
                EmpID = 3
            };

            var employee4 = new Employees()
            {
                FName = "Jerick",
                LName = "Castro",
                EmpID = 4
            };

            var employee5 = new Employees()
            {
                FName = "JR",
                LName = "Castro",
                EmpID = 5
            };

            var employee6 = new Employees()
            {
                FName = "Mary",
                LName = "Wang",
                EmpID = 6
            };

            var employee7 = new Employees()
            {
                FName = "Diane",
                LName = "Dayao",
                EmpID = 7
            };

            var employee8 = new Employees()
            {
                FName = "Eunice",
                LName = "Matta",
                EmpID = 8
            };

            var employee9 = new Employees()
            {
                FName = "Joe",
                LName = "Singh",
                EmpID = 9
            };

            var employee10 = new Employees()
            {
                FName = "Tigee",
                LName = "Wigey",
                EmpID = 10
            };

            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            employeeList.Add(employee4);
            employeeList.Add(employee5);
            employeeList.Add(employee6);
            employeeList.Add(employee7);
            employeeList.Add(employee8);
            employeeList.Add(employee9);
            employeeList.Add(employee10);

            employeeList.ForEach(x =>
            {
                if (x.FName == "Joe")
                {  
                    Console.WriteLine($"{x.FName} {x.LName}");
                }
            });

            employeeList.ForEach(y =>
            {
                if (y.EmpID > 5)
                {
                    Console.WriteLine($"{y.FName} {y.LName} has employee ID greater than 5");
                }
            });
            Console.ReadLine();
        }

    }
}
