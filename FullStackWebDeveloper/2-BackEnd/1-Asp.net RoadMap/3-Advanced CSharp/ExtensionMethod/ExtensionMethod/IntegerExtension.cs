using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    // 🔹 Static Class vs Sealed Class in C#

    // ✅ Static Class
    // - Cannot be instantiated (no objects can be created).
    // - Contains only static members (methods, properties, and fields).
    // - Cannot inherit from other classes and cannot be inherited.
    // - Used for utility/helper methods or global constants.
    // - Automatically sealed, meaning no subclassing is allowed.

    // ✅ Sealed Class
    // - Can be instantiated (objects can be created).
    // - Can contain both static and instance members.
    // - Cannot be inherited (prevents other classes from deriving from it).
    // - Used when you want to restrict inheritance for security or design reasons.

    // 🔹 Key Difference
    // - Static classes exist only as a type and cannot be instantiated.
    // - Sealed classes prevent inheritance but can still be instantiated.
    static class IntegerExtension
    {
        // 🔹 Extension Method in C#

        // - An extension method allows adding new methods to an existing class without modifying its source code.
        // - It is defined as a static method inside a static class.
        // - The first parameter of the method specifies the type it extends, using the 'this' keyword.
        // - Used to extend built-in .NET classes (like string, int, List<T>) or custom classes.
        // - Helps in writing cleaner, more reusable, and readable code.
        // - Does not modify the original class, just adds extra functionality externally.

        // 🔹 Why Do We Call an Extension Method from an Object Instead of the Type?

        // - Even though an extension method is static, it acts like an instance method of the type it extends.
        // - The 'this' keyword in the first parameter makes it behave as if it belongs to the type.
        // - That’s why we call it on an object (instance) of the type, not the type itself.
        // - The class defining the extension method is static, but the method is designed to be used on instances.

        public static bool IsRangeInBetween(this int Percentage, int min , int max)
        {
            return (Percentage >= min && Percentage <= max);
        }
    }
}
