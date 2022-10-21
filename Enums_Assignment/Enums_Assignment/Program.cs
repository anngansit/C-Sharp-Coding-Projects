using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Assignment
{
    public class Program
    {
        public enum DayofWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }


        public static void Main(string[] args)
        {

            string Days;

            try
            {
                Console.WriteLine("Enter the current day:");
                Days = Console.ReadLine();// readline string

                int dayNumber = (int)Enum.Parse(typeof(DayofWeek), Days);// converts string to index of enum

                DayofWeek myVar = (DayofWeek)Convert.ToInt32(dayNumber);// uses the index of enum to access the enum properties

                Console.WriteLine("The day is: "+ myVar);
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();


            }
       
        
            



    }
 }
