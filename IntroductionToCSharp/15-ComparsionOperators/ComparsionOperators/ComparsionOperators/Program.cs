namespace ComparsionOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Comparsion Operators is used to compare two values and return a boolean value.
            /*
             == is used to compare if two values are equal or not 
             != is used to compare if two values are not equal
             > is used to compare if the left value is greater than the right value
             < is used to compare if the left value is less than the right value
             >= is used to compare if the left value is greater than or equal to the right value
             <= is used to compare if the left value is less than or equal to the right value
            */
            int a = 10;
            Console.WriteLine($"a == 10 : {a == 10}"); // True
            Console.WriteLine($"a == 20 : {a == 20}"); // False
            Console.WriteLine($"a != 10 : {a != 10}"); // False
            Console.WriteLine($"a != 15 : {a != 15}"); // True
            Console.WriteLine($"a > 10 : {a > 10}"); // False
            Console.WriteLine($"a > 5 : {a > 5}"); // True
            Console.WriteLine($"a < 20 : {a < 20}"); // True
            Console.WriteLine($"a < 10 : {a < 10}"); // False
            Console.WriteLine($"a >= 10 : {a >= 10}"); // True
            Console.WriteLine($"a >= 15 : {a >= 15}"); // False
            Console.WriteLine($"a <= 10 : {a <= 10}"); // True
            Console.WriteLine($"a <= 2 : {a <= 2}"); // False
        }
    }
}
