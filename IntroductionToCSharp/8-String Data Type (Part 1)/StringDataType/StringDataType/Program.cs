namespace StringDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Escape Sequences in C# Strings 
            //Escape sequences are used to represent characters that are difficult to type or would otherwise be difficult to represent.
            //\n - New Line
            Console.WriteLine("Hello\nWorld");
            //\t - Tab
            Console.WriteLine("Hello\tWorld");
            //\b - Backspace
            //\r - Carriage Return
            //\\ - Backslash
            Console.WriteLine("Hello\\t\\t\\tWorld");
            //\' - Single Quote
            Console.WriteLine("Hello\'World");
            //\" - Double Quote
            Console.WriteLine("Hello\"World");
            //\u - Unicode Escape Sequence
            //\U - Unicode Escape Sequence
            //\x - Unicode Escape Sequence
            //\0 - Null
            //\a - Alert
            Console.WriteLine("Hello\aWorld");
            //\v - Vertical Tab
            //@ is used to make the \n and \t as normal characters and etc. as a normal character
            Console.WriteLine(@"Hello\t\t\tWorld");
            //@ can help you to write the variable value in more than one line without using the + operator
            string path = @"my name is 
            maher and i 
            love C# Programming Language";
            Console.WriteLine(path);
            //Concatenation is the process of appending one string to the end of another string.
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            Console.WriteLine(firstName + lastName);
            //String is array of characters in C# and we can access the characters of a string using the index.
            string name = "John Doe";
            Console.WriteLine(name[0]);
            Console.WriteLine(name);
            //String Template
            //String Interpolation in C# is a way to construct strings using placeholders.
            string name1 = "Maher Mahmoud Safwat";
            //$ is used to write the variable value in the string found in the placeholders and it is called string interpolation
            Console.WriteLine("My name is {name1}");
            Console.WriteLine($"My name is name1");
            Console.WriteLine($"My name is {name1}");

        }
    }
}
