using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_Internal
{
    class Rectangle:Shapes
    {
        public void PrintArea()
        {
            Console.WriteLine($"The Area of Rectangle is {Area}");
        }
    }
}
