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
          }
    }
}
