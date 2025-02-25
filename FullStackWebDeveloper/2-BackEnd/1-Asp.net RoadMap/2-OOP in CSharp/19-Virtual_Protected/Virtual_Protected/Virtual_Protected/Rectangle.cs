using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Protected_Member
{
    class Rectangle : Shape
    {
        public Rectangle()
        {
            TypeName = "Rect";
        }
        public int Length { set; get; }
        public int Width { set; get; }
        public override double CalculateArea()
        {
            return Length * Width;
        }
        /*
        Virtual is also use an override keyword method and it means that you are not forced to make your own implementation in every class
        that inherits from shape class (Parent Class).
        */
        // The 'virtual' keyword allows a method to be overridden in a derived class.

        // If a method is marked as 'virtual', a derived class can change its behavior using 'override'.

        // When a method is 'virtual', calling it on a base class reference executes the overridden version in the derived class.

        // If a derived class does not override a 'virtual' method, the base class version is used by default.

        // 'virtual' enables polymorphism, allowing dynamic method dispatch at runtime.

        // Without 'virtual', a method cannot be overridden in a subclass.

        public override void PrintArea()
        {
            /*
            Calling base.PrintArea(); means executing the parent class's version of PrintArea(), 
            even if the derived class has its own overridden version.
            */
            base.PrintArea();
            Console.WriteLine($"Rectangle Length is {Length} and Width is {Width} it is area is {CalculateArea()}");
        }
    }
}
