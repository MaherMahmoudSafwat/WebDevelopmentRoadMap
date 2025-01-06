namespace TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ternary Operator is a shorthand way of writing an if-else statement
            for (int i = 0; i < 10; i++)
            {
                //Ternay Operator Should be used when the if-else statement is simple and can be written in one line
                //If the if-else statement is complex, it is better to use the if-else statement
                //Ternary Operator is not a replacement for if-else statement
                //It is just a shorthand way of writing an if-else statement
                //It is also called Conditional Operator
                //Ternary Operator Should return a value
                //It should not be used to perform an action like printing a statement.
                string Statement = (i % 2 == 0 ? $"{i} is even" : $"{i} is odd");
                //if (i%2 == 0)
                //{
                //    Console.WriteLine($"{i} is even");
                //}
                //else
                //{
                //    Console.WriteLine($"{i} is odd");
                //}
                Console.WriteLine(Statement);
            }
        }
    }
}
