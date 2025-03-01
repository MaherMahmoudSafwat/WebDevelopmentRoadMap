namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        // Abstraction is the process of hiding implementation details and exposing only necessary functionality.
        // It helps in reducing complexity and improving code maintainability.
        // Abstraction in C# is achieved using **abstract classes** and **interfaces**.

            // --------------- ABSTRACT CLASSES ---------------
            // Abstract classes provide a **partial abstraction** (they can have both abstract and concrete methods).
            // They allow defining common behaviors that derived classes can inherit or override.

        abstract class Animal
        {
            private int x = 5;
            // Abstract method (no implementation, forces derived classes to define it)
            public abstract void MakeSound();

            // Concrete method (has implementation, can be inherited directly)
            public void Sleep()
            {
                // Common functionality for all animals
            }
        }

        // Derived class provides the specific implementation of the abstract method
        class Dog : Animal
        {
            public override void MakeSound()
            {
                // Implementation specific to Dog
            }
        }

        // --------------- INTERFACES ---------------
        // Interfaces provide **full abstraction** (they cannot have any implementation).
        // They define a contract that classes must follow without providing any code.

        interface IVehicle
        {
            const int x = 5;
            // No implementation, only method signatures (contract for any class implementing this interface)
            void Start();
            void Stop();
        }

        // A class implementing the interface must provide definitions for all methods
        class Car : IVehicle
        {
            public void Start()
            {
                // Car-specific start logic
            }

            public void Stop()
            {
                // Car-specific stop logic
            }
        }

        // --------------- HOW THEY HELP IN ACHIEVING ABSTRACTION ---------------
        // ✅ Abstract classes allow defining common behaviors while enforcing some methods to be implemented in
        // derived classes.
        // ✅ Interfaces provide a strict contract, ensuring different classes follow the same structure.
        // ✅ Both help in writing modular, maintainable, and loosely coupled code.
        // ✅ They enable **code reusability**, **separation of concerns**, and **flexibility** in designing applications.
        // ------------------ DIFFERENCE BETWEEN ABSTRACT CLASSES AND INTERFACES ------------------

        // 1️⃣ **Abstraction Level**
        // - Abstract classes provide **partial abstraction** (can have both abstract and concrete methods).
        // - Interfaces provide **full abstraction** (only method signatures, no implementation).

        // 2️⃣ **Method Implementation**
        // - Abstract classes can have methods with implementation (concrete methods).
        // - Interfaces cannot have any implemented methods (before C# 8.0), only method signatures.

        // 3️⃣ **Fields and Properties**
        // - Abstract classes can have **fields, constructors, and properties**.
        // - Interfaces cannot have fields (they can have properties, but without implementation).

        // 4️⃣ **Multiple Inheritance Support**
        // - A class **can inherit only one abstract class** (single inheritance).
        // - A class **can implement multiple interfaces** (multiple inheritance).

        // 5️⃣ **Use Case Differences**
        // - Abstract classes are used when classes share common behavior but need some customization.
        // - Interfaces are used when different classes need to follow the same contract but are unrelated.

        // 6️⃣ **Constructors**
        // - Abstract classes **can have constructors** (for initializing fields).
        // - Interfaces **cannot have constructors**.

        // 7️⃣ **Access Modifiers**
        // - Abstract class members can have different access modifiers (public, private, protected, etc.).
        // - Interface members are always **public by default** (cannot have access modifiers).

        // 8️⃣ **Performance**
        // - Abstract classes are faster than interfaces since they allow direct inheritance.
        // - Interfaces are slightly slower because method calls go through **runtime lookups** (unless optimized).

        // ------------------ WHEN TO USE WHICH? ------------------
        // ✅ Use **abstract classes** when:  
        //   - You want to provide **default behavior** that derived classes can inherit or override.  
        //   - The classes have a **common base structure** (e.g., Animal, Vehicle).  

        // ✅ Use **interfaces** when:  
        //   - You want to enforce a **common contract** across multiple unrelated classes.  
        //   - You need **multiple inheritance** (since a class can implement multiple interfaces).  

    }

}
