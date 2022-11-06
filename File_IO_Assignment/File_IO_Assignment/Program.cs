using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string text = Console.ReadLine();


            File.WriteAllText(@"C:\Anna\Logs\logs.txt", text);
           
        }
        
    }
}
