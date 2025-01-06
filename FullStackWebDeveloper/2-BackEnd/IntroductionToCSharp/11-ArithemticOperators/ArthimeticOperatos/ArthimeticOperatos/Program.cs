namespace ArthimeticOperatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arithmetic Operators in C# are used to perform mathematical operations on variables.
            //Arithmetic Operators are used to perform addition, subtraction, multiplication, and division.
            /*
             Addition (+)
             Subtraction (-)
             Multiplication (*)
             Division (/)
             Modulus (%)
            */
            int a = 10;
            int b = 20;
            Console.WriteLine($"Addition of {a} and {b} is {a + b}");
            Console.WriteLine($"Subtraction of {a} and {b} is {a - b}");
            Console.WriteLine($"Multiplication of {a} and {b} is {a * b}");
            //Division of two integers will always result in an integer.    
            Console.WriteLine($"Division of {a} and {b} is {a / b}");
            Console.WriteLine($"Modulus of {a} and {b} is {a % b}");
            a = 10;
            double c = 20.5;
            //Division of an integer and a double will result in a double.
            //If one of the operands is a double, the result will be a double.
            /*float and double are the same in C#, as if float and integer are used in the same operation,
            the result will be a double.*/
            Console.WriteLine($"Division of {a} and {b} is {a / c}");
            //a and b are operands.
            //+, -, *, /, and % are operators.
        }
    }
}
