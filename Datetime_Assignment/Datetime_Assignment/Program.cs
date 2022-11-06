using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Datetime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var date2 = DateTime.Now;
            Console.WriteLine(date2);
            
            Console.WriteLine("\nPlease enter a number:");
            string text = Console.ReadLine();

            File.WriteAllText(@"C:\Anna\Logs\logs.txt", text);
            Console.WriteLine("\n" + text + " hours");
           
            Console.ReadLine();
            
        }
    }
}
