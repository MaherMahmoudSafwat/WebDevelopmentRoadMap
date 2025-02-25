using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protected_Internal;

namespace Project2
{
    class Circle:Shapes
    {
        public void PrintArea()
        {
            Console.WriteLine($"The area of the circle is {Area}");
        }
    }
}
