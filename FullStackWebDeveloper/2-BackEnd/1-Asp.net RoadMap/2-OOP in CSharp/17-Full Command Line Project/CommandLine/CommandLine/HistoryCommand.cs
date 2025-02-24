using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLine
{
    class HistoryCommand
    {
        private static StringBuilder Attributes = new StringBuilder();
        private static StringBuilder Path = new StringBuilder();
        private static bool IsValidCommand()
        {
            Attributes.Append(CommandParser.ExtractAtributes(CommandParser.FullPath));
            Path.Append(CommandParser.ExtractPath(CommandParser.FullPath));
            if (Attributes.Equals(""))
            {
                Console.WriteLine("History Commands need at least one Argument.");
                Attributes.Clear();
                Path.Clear();
                return false;
            }
            if (CommandParser.IsThereRemainingCommandsInTheString(CommandParser.FullPath) || !Path.Equals(""))
            {
                Console.WriteLine("The system can't find the specified path.");
                Attributes.Clear();
                Path.Clear();
                return false;
            }
            return true;
        }
        private static void ReadHistory()
        {
            foreach (string Line in File.ReadLines(Program.FileName))
                Console.WriteLine(Line);
        }
        private static void DeleteHistory()
        {
            File.Delete(Program.FileName);
            Console.WriteLine("File History Has been deleted successfully.");
        }
        public static void History()
        {
            if(IsValidCommand())
            {
                if (Attributes.Equals("-r"))
                {
                    ReadHistory();
                }
                else if (Attributes.Equals("-d"))
                {
                    DeleteHistory();
                }
                else
                {
                    Console.WriteLine("Invalid Arguments, Please try again.");
                }
            }
            Attributes.Clear();
            Path.Clear();
        }
    }
}
