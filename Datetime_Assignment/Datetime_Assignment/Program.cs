using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Datetime_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
            
        {
            //DateTime d = new DateTime();
            DateTime d1 = DateTime.Now;
            Console.WriteLine("Current time is:");
            Console.WriteLine(d1);
   
            Console.WriteLine("\nPlease enter a number to add:");
            double x = Convert.ToDouble(Console.ReadLine());
          
            DateTime d2 = d1.AddHours(x);
            Console.WriteLine("Current time plus the number of hours you entered is:");
            Console.WriteLine(d2);

            Console.ReadLine();
        }

        //File.WriteAllText(@"C:\Anna\Logs\logs.txt", text);

    }
}
  