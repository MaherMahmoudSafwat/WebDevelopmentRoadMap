using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    class Rectangle : Shape 
    {
        public int Length { set; get; }
        public int Width { set; get; }
        public override double CalculateArea()
        {
            return Length * Width;
        }
    }
}
