namespace ArithemticPrecedence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arithmetic precedence is the order in which arithmetic operations are performed.
            //The order of precedence is as follows:
            //1. Parentheses
            //2. Exponents
            //3. Multiplication and division
            //4. Addition and subtraction
            Console.WriteLine(5 + 10 * 2); // 25
            Console.WriteLine((5 + 10) * 2); // 30
            Console.WriteLine(5 + 10 / 2); // 10
            Console.WriteLine(5 * 2 + 10 / 2); // 15
            Console.WriteLine(5 * (2 + 10) / 2); // 30
            //The ^ operator is not used for exponentiation in C#. Instead, you can use the Math.Pow method.
            Console.WriteLine(5 * 2 + 3 + Math.Pow(2, 2) + (5 - 1) / 2 * 4);//25
            //5/2 is 2.5 but since we are using integer division, the result is 2.
            Console.WriteLine(5 / 2); // 2
            //To get the correct result, you can cast one of the operands to a double.
            Console.WriteLine(5.5 / 2); // 2.75
        }
    }
}
