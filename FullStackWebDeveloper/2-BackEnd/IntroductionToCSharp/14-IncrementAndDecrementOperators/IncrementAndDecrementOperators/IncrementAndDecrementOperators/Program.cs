namespace IncrementAndDecrementOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //x=10 ---> x=x+10 Or x+=10
            //Postfix increment is used to increment the value of the variable after the value is used in the expression.
            int x = 10;
            x++;
            Console.WriteLine($"x: {x}"); //Output: 11
            Console.WriteLine($"x: {x++}"); //Output: 11
            Console.WriteLine($"x: {x}"); //Output: 12
            //Prefix increment is used to increment the value of the variable before the value is used in the expression.
            int y = 10;
            ++y;
            Console.WriteLine($"y: {y}"); //Output: 11
            Console.WriteLine($"y: {++y}"); //Output: 12
            //Postfix and Prefix are the same only if they are used in a single statement.
            Console.WriteLine($"5*x++ is :- {5 * x++}"); //Output: 5*12=60
            Console.WriteLine($"x: {x}"); //Output: 13
            Console.WriteLine($"5*++x is :- {5 * ++x}"); //Output: 5*14=70
            Console.WriteLine($"x: {x}"); //Output: 14
            //Postfix decrement is used to decrement the value of the variable after the value is used in the expression.
            int z = 10;
            z--;
            Console.WriteLine($"z: {z}"); //Output: 9
            Console.WriteLine($"z: {z--}"); //Output: 9
            Console.WriteLine($"z: {z}"); //Output: 8
            //Prefix decrement is used to decrement the value of the variable before the value is used in the expression.
            int a = 10;
            --a;
            Console.WriteLine($"a: {a}"); //Output: 9
            Console.WriteLine($"a: {--a}"); //Output: 8
            //Postfix and Prefix are the same only if they are used in a single statement.
            Console.WriteLine($"5*z-- is :- {5 * z--}"); //Output: 5*8=40
            Console.WriteLine($"z: {z}"); //Output: 7
            Console.WriteLine($"5*--z is :- {5 * --z}"); //Output: 5*6=30
            Console.WriteLine($"z: {z}"); //Output: 6
            Console.WriteLine(a++ + a++ + ++a);//28
            /*
             Explanation:
            First a++ (Post-Increment):

            Returns 8, but a is incremented after the operation.
            Now, a = 9.
            Second a++ (Post-Increment):

            Returns 9, but a is incremented after the operation.
            Now, a = 10.
            ++a (Pre-Increment):

            a is incremented before the operation.
            Now, a = 11.
            Returns 11.
            */
        }
    }
}
