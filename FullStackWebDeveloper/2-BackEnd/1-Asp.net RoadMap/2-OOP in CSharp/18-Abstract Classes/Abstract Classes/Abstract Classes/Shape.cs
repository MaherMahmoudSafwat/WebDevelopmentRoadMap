using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    abstract class Shape 
    {
        //You can't have abstract methods in non abstract class but you can have abstract class without any abstract methods. 
        public abstract double CalculateArea();
        public void PrintArea()
        {
            Console.WriteLine($"The area of the circle is {CalculateArea()}");
        }
    }
}
