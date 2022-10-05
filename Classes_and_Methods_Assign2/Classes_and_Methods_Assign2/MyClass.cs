using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assign2
{
    class MyClass
    {

        public void Calculate(int Length, int Width=1)
        {
            Double Area = Length * Width;
            Console.WriteLine("The Area is:" + Area);
            Console.ReadLine();

        }

    }
}


