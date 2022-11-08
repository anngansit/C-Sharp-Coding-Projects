using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features_Assignment
{
    class RentalDetails
    {
        string occasion;
        int hours;
        string color;
      

        public RentalDetails(string occasion, int hours, string color)
        {
            this.occasion = occasion;
            this.hours = hours;
            this.color = color;
            
        }

        public void Rent()  
        {
            Console.WriteLine("You rented the photobooth for: " + occasion + "\nlength is: " + hours + " hours " + " \nand theme color is: " + color);
        }
    }
}
