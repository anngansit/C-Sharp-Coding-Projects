using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console App Assignment Part 1
            string[] names = new string[6];
            Console.WriteLine("Enter the name of your 6 friends.");

            names[0] = Console.ReadLine();
            names[1] = Console.ReadLine();
            names[2] = Console.ReadLine();
            names[3] = Console.ReadLine();
            names[4] = Console.ReadLine();
            names[5] = Console.ReadLine();

            Console.WriteLine("Your friend's names are:");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadLine();

            //Finding duplicate in the list
            var duplicates = names.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => y.Key)
              .ToList();

            Console.WriteLine("This names appears more than once.");
            Console.WriteLine(String.Join(", ", duplicates));
            Console.ReadLine();

            //Searching in array
            Console.WriteLine("Enter name to find.");
            string friendName = Console.ReadLine();

            bool contains = false;
            for (int f = 0; f<friendName.Length; f++)
            {
                if (friendName == names[f])
                {
                    contains = true;
                    break;
                }
            }

            if (contains == true)
            {
                Console.WriteLine("The name you entered is in your friends list.\n");
            }
            else
            {
                Console.WriteLine("The name you entered is not in your friends list.\n");
            }
            Console.ReadLine();

            ////Infinite Loop
            //for (int i = 0; ; i++)
            //{
            //    //Console.WriteLine(i + ", "); 
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //loop up to 10
            Console.WriteLine("Loop 1 to 10.");
            for (int i = 0; i <= 10; i++)
            {
                //Console.WriteLine(i + ", "); 
                Console.WriteLine(i);
            }
            Console.ReadLine();





        }
    }
}
