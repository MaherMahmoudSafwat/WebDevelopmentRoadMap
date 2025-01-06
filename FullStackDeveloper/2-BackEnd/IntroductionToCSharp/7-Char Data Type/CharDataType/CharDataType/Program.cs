namespace CharDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.read() is used to read a single character from the console and returns the ASCII value of the character
            Console.WriteLine("Enter a character Then Press Enter: ");
            int C1 = Console.Read();
            int C2 = Console.Read();
            int C3 = Console.Read();
            //Enter is also a character so it will also be read by the Console.Read() method it will return the ASCII value of Enter
            //ASCII value of Enter is 13 and ASCII value of New Line is 10
            int C4 = Console.Read();
            int C5 = Console.Read();
            Console.WriteLine("ASCII value of the character is: " + C1);
            Console.WriteLine("ASCII value of the character is: " + C2);
            Console.WriteLine("ASCII value of the character is: " + C3);
            Console.WriteLine("ASCII value of the character is: " + C4);
            Console.WriteLine("ASCII value of the character is: " + C5);
            //Char is used to store a single character in C#.
            char C = 'A';
            Console.WriteLine("ASCII value of the character is: " + (int)C);
            Console.WriteLine("Character of C is " + C );
            //Char is Struct type in C# and it has it is own methods and properties
            bool isDigit = Char.IsDigit(C);
            bool IsLetter = Char.IsLetter(C);
            Console.WriteLine("Is C a Digit: " + isDigit);
            Console.WriteLine("Is C a Letter: " + IsLetter);

        }
    }
}
