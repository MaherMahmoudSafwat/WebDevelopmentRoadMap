namespace Abstract_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Rectangle = new Rectangle { Length = 10, Width = 25 };//Object Initalizater 
            Rectangle.PrintArea();

            var Circle = new Circle { Radius = 15 };
            Circle.PrintArea();

            //You can't make an object from abstract class 
            //Shape S1 = new Shape;//Error this is not allowed.

            //You can make reference of parent class and to points to object of it is sub classes from it.
            Shape S1 = new Rectangle { Length = 35, Width = 57 };
            S1.PrintArea();

            S1 = new Circle { Radius = 91 };
            S1.PrintArea();

            //In C# OOP It doesn't support multiple inheritance meaning that the class will only inherits from one another class. 
            //class Rectangle : Circle , Shape //This is Not Allowed 
        }
    }
    //If you want to make a class that no one inheriteds from it use sealed class keyword
    sealed class Printer
    {

    }
    /*class Test : Printer
    {

    }*///This is not allowed in C#. 
}
