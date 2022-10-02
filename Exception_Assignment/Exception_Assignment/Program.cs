using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numArrays = { 1000, 2000, 3000, 4000 };

                Console.WriteLine("Please enter a number:");
                float dividend = Convert.ToInt32(Console.ReadLine());


                for (int i = 0; i < 4; i++)
                {
                    float answer = numArrays[i] / dividend;
                    Console.WriteLine(numArrays[i] + " divided " + dividend + " equals: " + answer);
                    Console.ReadLine();
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { }
            Console.ReadLine();
        }
    }
}


        
    



