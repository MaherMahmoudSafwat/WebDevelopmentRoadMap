using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    class Circle : Shape
    {
        public double Radius { set; get; }
        //You must use override to make the inherite class do and make it is own implementation in the abstract method. 
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
