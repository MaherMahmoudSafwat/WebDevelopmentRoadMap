using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member_Hiding_and_Shadowing
{
    class Rectangle:Shape
    {
        // ------------------------
        // Difference Between override, virtual, and new in C#
        // ------------------------

        /* 
           🔹 virtual 
           - Declares a method in the base class that can be overridden by derived classes.
           - Enables **runtime polymorphism**.
           - Must be used with `override` in a derived class.
        */

        /*
           🔹 override 
           - Modifies a `virtual` method in a derived class.
           - The base class method is **replaced** at runtime.
           - Supports **dynamic method resolution**.
        */

        /*
           🔹 new 
           - Hides a base class method instead of overriding it.
           - Does **not** support polymorphism.
           - The base class method is still accessible if called explicitly.
        */

        /*
           🔹 Key Differences:
           - `virtual` allows method overriding in a derived class.
           - `override` provides a new implementation for a `virtual` method.
           - `new` hides the base method without overriding it.
        */

        /*
           🔹 Behavior in Polymorphism:
           - `override` ensures the derived class method is executed when accessed via a base class reference.
           - `new` only hides the method when accessed via a derived class reference, but the base method remains available.
        */

        /*
           🔹 Use Cases:
           - Use `virtual` + `override` when you want derived classes to provide a different behavior.
           - Use `new` when you want to redefine a method without affecting the base class behavior.
        */

        public new void PrintArea()
        {
            Console.WriteLine("Area is 357");
        }
    }
}
