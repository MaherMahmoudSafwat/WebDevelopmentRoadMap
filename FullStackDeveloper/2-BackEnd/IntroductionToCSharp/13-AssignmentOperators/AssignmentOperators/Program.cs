namespace AssignmentOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment Operators are used to assign values to variables.
            //The following assignment operators are supported in C#:
            // =, +=, -=, *=, /=, %=, &=, |=, ^=, <<=, >>=
            int x = 10;
            int y = 5;
            int z = 10;
            x = x + 10; // x is 20
            x += 10; //x = x +10 // x is 30
            Console.WriteLine($"x: {x}");
            y = y - 5; // y is 0
            y -= 5; //y = y - 5 // y is -5
            Console.WriteLine($"y: {y}");
            z = z * 2; // z is 20
            z *= 2; //z = z * 2 // z is 40
            Console.WriteLine($"z: {z}");
            x = x / 2; // x is 20
            x /= 2; // x = x / 2 // x is 7
            Console.WriteLine($"x: {x}");
            y = y % 2; // y is -3
            y %= 2; //y = y % 2 // y is -1
            Console.WriteLine($"y: {y}");
            //x = y = z = 15
            x = y = z = 15;
            Console.WriteLine($"x: {x}, y: {y}, z: {z}");
        }
    }
}
