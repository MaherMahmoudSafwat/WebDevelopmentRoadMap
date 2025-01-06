namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable
            string name;
            //Assign a value to the variable
            name = "John";
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);
            //Variables rules is same as C++.
            //@ is used in C# to treat a string as a literal. It is useful when we want to use a reserved keyword as a variable name.
            string @void = "A";
            Console.WriteLine(@void);
            //var is a keyword that is used to declare a variable and initialize it at the same time.
            //The type of the variable is inferred by the compiler.
            var a = 10;
            Console.WriteLine($"a = {a}");
            //a = "abc" ; //Error: Cannot implicitly convert type 'string' to 'int'
            //Declaration ---> int a;
            //Assignment ---> a = 10;
            //Initialization ---> int a = 10;
            var a = 10; //a is a variable of type int
            // a = "C#"; //Error: Cannot implicitly convert type 'string' to 'int'
            var b = 29.5f;//b is a variable of type float 
            var c = 29.5;//c is a variable of type double
            var d = 29.5d;//d is a variable of type double
            var e = 29.5m;//e is a variable of type decimal

            //dynamic type is a type that bypasses compile-time type checking
            //dynamic is used when you don't know the type at compile time
            //dynamic is used in runtime type checking and late binding
            dynamic f = 10;
            //f = 10; //No error because f is of type dynamic and it can hold any type of value at runtime 
            Console.WriteLine(f);
            f = "C#";
            //f = "C#"; //No error because f is of type dynamic and it can hold any type of value at runtime 
            Console.WriteLine(f);
            //to know the type of a variable use GetType() method
            Console.WriteLine(f.GetType());
            f = 15.5;
            Console.WriteLine(f.GetType());
          }
    }
}
