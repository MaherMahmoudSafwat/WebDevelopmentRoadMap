using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Protected_Member
{
    abstract class Shape
    {
        // The 'protected' access modifier allows a member to be accessed within its class and by derived classes.

        // 'protected' members are not accessible from outside the class unless through inheritance.

        // If a field or method is marked as 'protected', only subclasses can directly use or modify it.

        // Unlike 'private', which restricts access only to the declaring class, 'protected' extends access to subclasses.

        // 'protected' is useful for creating a base class with functionality that derived classes can use or modify. 

        // A 'protected' method or property cannot be accessed using an instance of the class; it is only accessible within the inheritance chain.

        protected string TypeName { set; get; }
        //You can't have abstract methods in non abstract class but you can have abstract class without any abstract methods. 
        public abstract double CalculateArea();
        public virtual void PrintArea()
        {
            Console.WriteLine($"The area of {TypeName} is {CalculateArea()}");
        }
    }
}
