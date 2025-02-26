namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You can't create an instance from abstract class data type or interface.
            //Idevice Device = new Idevice();Error Not Allowed.
            Idevice Device = new ComputerDevice();
            Device.TurnOn();
            Device.TurnOff();
            Device = new MobileDevice();
            Device.TurnOn();
            Device.TurnOff();
            IRestartable RestartDevice = new ComputerDevice();
            RestartDevice.Restart();
            RestartDevice = new MobileDevice();
            RestartDevice.Restart();
            MobileDevice MobileDevice = new MobileDevice();
            MobileDevice.TurnOn();

            //-------------------
            Device = new ComputerDevice();
            Device.TurnOn();//This will implement the method implemented by subclass that inherited from it is interface.
            ComputerDevice ComputerDevice = new ComputerDevice();
            ComputerDevice.TurnOn();

            Idevice RestartMobileDevice = new MobileDevice();
            RestartMobileDevice.Restart();
            MobileDevice Mobile = new MobileDevice();
            Mobile.Restart();
            Idevice LightBulb = new LightBulb();
            LightBulb.Restart();

            //Abstract Classes vs Interface Classes 
            // ------------------------
            // Difference Between Abstract Classes and Interfaces in C#
            // ------------------------

            /*
               🔹 Abstract Classes:
               - Used to define a **base class** with some **default behavior**.
               - Can have **both** fully implemented methods and abstract methods (without implementation).
               - Supports **constructors**, **fields**, and **access modifiers** (private, protected, etc.).
               - Cannot be instantiated directly.
               - Allows **single inheritance** (a class can inherit only one abstract class).
               - Best suited when you need a **common base class with shared functionality**.
            */

            /*
               🔹 Interfaces:
               - Used to define a **contract** that classes must follow.
               - Can only contain **method declarations**, properties, events, and indexers (no implementation until C# 8.0+).
               - Cannot have constructors, fields, or access modifiers (all members are public by default).
               - Supports **multiple inheritance** (a class can implement multiple interfaces).
               - Best suited when you need to enforce **a set of behaviors** across different classes without shared implementation.
            */

            /*
               🔹 Key Differences:
               - Abstract classes **can** have method implementations, while interfaces **cannot** (until C# 8.0).
               - Interfaces **support multiple inheritance**, but abstract classes do not.
               - Abstract classes can have **constructors and fields**, while interfaces cannot.
               - Interfaces are **purely for defining behavior**, whereas abstract classes are for **defining structure and shared functionality**.
            */

            /*
               🔹 When to Use What?
               - Use **abstract classes** when you want to provide **common functionality** and **default behavior**.
               - Use **interfaces** when you want to enforce **a contract** across multiple unrelated classes.
            */

        }
    }
}
