namespace CommandLine
{
    internal class Program
    {
        public static string FullPathName = "C:\\>";
        public static string FileName = "C:\\Users\\Maher\\History.txt";
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t\tWelcome to the command line prompt");
            while (true)
            {
                Console.Write(FullPathName);
                string UserPath = Console.ReadLine();
                if (UserPath == "")
                    continue;
                File.AppendAllText(FileName, UserPath);
                File.AppendAllText(FileName, "\n");
                CommandParser.CommandsLinePrompt(CommandParser.ExtractCommand(UserPath));
            }
        }
    }
}
