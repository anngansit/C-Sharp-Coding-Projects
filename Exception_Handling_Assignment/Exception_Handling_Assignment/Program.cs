using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Good Morning.");
            try
            {
                bool ValidAge = false;
                int YourAge = 0;
                while (!ValidAge)
                {

                    
                    Console.WriteLine("Please type in your age");
                   
                    ValidAge = int.TryParse(Console.ReadLine(), out YourAge);
                    if (!ValidAge) throw new Exception();

                }
                if (YourAge == 0)
                {
                    throw new Exceptions.ZeroException();
                }
                if (YourAge < 0)
                {
                    throw new Exceptions.NegativeException();
                }
                if (YourAge > 150)
                {
                    throw new Exceptions.TooBigException();
                }

                string CurrentDate = DateTime.Now.ToString("yyyy");
                Double DateOfBirth = Convert.ToDouble(CurrentDate) - YourAge;
                Console.WriteLine("You are " + YourAge + " years old.\nYour Date Of Birth is : " + DateOfBirth);
            }

            catch (Exceptions.NegativeException)
            {
             
                Console.WriteLine("Positive Values only.");
                Console.ReadLine();


            }
            catch (Exceptions.ZeroException)
            {
                
                Console.WriteLine("Your age can't be zero");
                Console.ReadLine();


            }
            catch (Exceptions.TooBigException)
            {
                
                Console.WriteLine("Awesome!  Sorry but your age is not possible.  Unless you are from another world.");
                Console.ReadLine();

            }
            catch (Exception)
            {
                
                Console.WriteLine("Error! Should be numbers only!");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
