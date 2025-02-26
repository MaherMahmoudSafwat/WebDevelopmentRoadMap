using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace ArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Strong Typed Collection.
            //Strong Typed Array.
            int[] Array = new int []{ 1, 2, 3 };

            ArrayList Array1 = new ArrayList();
            Array1.Add(1);
            Array1.Add("Test");
            Array1.Add(true);
            Array1.AddRange(new int[] {1,2,3});
            Array1.InsertRange(3, new int[] { 4, 5, 6 });
            foreach(object i in Array1)
            {
                Console.WriteLine(i);
            }
            Array1.Remove(1);
            Console.WriteLine("=================");
            foreach (object i in Array1)
            {
                Console.WriteLine(i);
            }
            Array1.RemoveRange(1, 3);
            Console.WriteLine("-----------------");
            foreach (object i in Array1)
            {
                Console.WriteLine(i);
            }
            // ------------------------
            // Object Class in C#
            // ------------------------

            /*
               🔹 The `Object` class is the **base class** for all types in C#.
               - Every class in C# **implicitly inherits** from `Object`, either directly or indirectly.
               - It is located in the `System` namespace.

               🔹 Key Features:
               - Provides basic methods that are **inherited by all classes**.
               - Enables **polymorphism** by allowing objects to be referenced generically.

               🔹 Important Methods of the `Object` Class:
               1️⃣ `ToString()`  → Returns a string representation of the object.
               2️⃣ `Equals(object obj)`  → Compares two objects for equality.
               3️⃣ `GetHashCode()`  → Returns a hash code for the object.
               4️⃣ `GetType()`  → Returns the runtime type of the object.
               5️⃣ `MemberwiseClone()`  → Creates a shallow copy of the object.
               6️⃣ `Finalize()`  → Called by the garbage collector before an object is destroyed.

               🔹 Why Is It Important?
               - Since all types inherit from `Object`, it allows **generic handling of objects**.
               - Used in **collections, reflection, and method overrides** to provide standard behavior.
               - Helps implement **custom equality checks** by overriding `Equals()` and `GetHashCode()`.

               🔹 Best Practices:
               - Override `ToString()` for meaningful string representation of objects.
               - Override `Equals()` and `GetHashCode()` when defining **custom equality logic**.
               - Use `GetType()` for **runtime type inspection**.

               🔹 Summary:
               - The `Object` class is the **root of the .NET type hierarchy**.
               - Provides fundamental methods that **all objects in C# inherit**.
               - Allows objects to be **handled generically** while enabling customization via method overrides.
            */

            //Boxing and UnBoxing.
            int x = 3;
            object y = x;//Boxing
            int z = x + (int)y;//UnBoxing.
            Console.WriteLine(z);
            // ------------------------
            // 🔹 Boxing and Unboxing in C#
            // ------------------------

            /*
               🔹 **Boxing**
               - The process of **converting a value type (e.g., int, double, bool)** into a **reference type (object)**.
               - This happens because value types are stored on the **stack**, while objects are stored on the **heap**.
               - Boxing **wraps the value inside an object**, moving it from the stack to the heap.
               - It is **implicit**, meaning it happens automatically.

               🔹 **Unboxing**
               - The process of **extracting a value type from a boxed object**.
               - This moves the value **from the heap back to the stack**.
               - Unboxing requires **explicit casting**, meaning the type must be specified.
               - If the cast is incorrect, it throws an `InvalidCastException`.

               🔹 **Performance Impact**
               - Boxing and unboxing involve **extra memory allocation and processing**.
               - Boxing requires **allocating heap memory**, which is slower than stack memory.
               - Unboxing requires **casting**, adding an extra step.
               - Frequent boxing/unboxing can lead to **performance issues**.

               🔹 **How to Avoid Boxing/Unboxing?**
               - Use **generics (`List<T>`)** instead of collections like `ArrayList` (which stores objects).
               - Avoid using the `object` type unnecessarily.
               - Use **structs** carefully to minimize boxing.

               🔹 **Summary**
               - **Boxing:** Value Type ➝ Object (Heap) **(Implicit)**
               - **Unboxing:** Object (Heap) ➝ Value Type **(Explicit with Casting)**
               - **Performance issue:** Avoid frequent boxing/unboxing to improve efficiency.
            */
            /*
            object x = 9;
            Memory Allocation Explanation:
            9 is an integer, which is a value type(normally stored on the stack).
            Assigning 9 to object x causes boxing:
            The value(9) is moved from the stack to the heap.
            x(the reference) is stored on the stack, pointing to the boxed integer in the heap.
            Summary:
            Reference(x) is stored on the stack.
            Actual value(9) is stored inside an object on the heap(because of boxing).
            */
            Array1.Add(1);
            int c = (int)Array1[Array1.Count - 1];
            Console.WriteLine(c);
        }
    }
}
