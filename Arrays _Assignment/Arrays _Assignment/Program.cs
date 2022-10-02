using System;
using System.Collections.Generic;


namespace Arrays__Assignment
{
    class Program
    {
        static void Main()
        {
            //User selecting an array
            string[] cars = new string[4];

            cars[0] = ("Porshe");
            cars[1] = ("BMW");
            cars[2] = ("Honda");
            cars[3] = ("Toyota");

            Console.WriteLine("Select an index of the array.");

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Enter {0} to select {1}", i, cars[i]);
            }

            string choice = Console.ReadLine();
            int j = int.Parse(choice);
            Console.WriteLine("You have selected {0} which is {1}", j, cars[j]);
            Console.ReadLine();

            



            //User selecting an Integer
            int[] numArrays = new int[4] { 90, 91, 92, 93 };

            Console.WriteLine("select an index of the integer.");

            for (int n = 0; n < numArrays.Length; n++)
            {
                Console.WriteLine("Enter {0} to select {1}", n, numArrays[n]);
            }

            string select = Console.ReadLine();
            int x = int.Parse(select);
            Console.WriteLine("You have selected {0} and the value is {1}", x, numArrays[x]);
            Console.ReadLine();

      

        }
    }
}
