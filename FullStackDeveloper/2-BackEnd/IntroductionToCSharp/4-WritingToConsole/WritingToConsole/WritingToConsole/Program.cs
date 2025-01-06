namespace WritingToConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Title is used to change the title of the console window
            Console.Title = "Writing to Console";
            //Console.foregroundColor = ConsoleColor.Green is used to change the color of string
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, World!");
            //Console.backgroundColor = ConsoleColor.Yellow is used to change the color of background of the string
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("I Love C#");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadKey();
        }
    }
}
