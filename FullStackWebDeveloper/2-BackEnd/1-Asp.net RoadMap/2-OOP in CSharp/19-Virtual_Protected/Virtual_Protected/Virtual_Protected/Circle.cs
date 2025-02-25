using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Protected_Member
{
    class Circle : Shape 
    {
        public Circle()
        {
            TypeName = "Circle";
        }

        public double Radius { set; get; }
        //You must use override to make the inherite class do and make it is own implementation in the abstract method. 
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
