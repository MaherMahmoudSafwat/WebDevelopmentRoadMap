using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLine
{
    class ClearCommand
    {
        private static StringBuilder Attributes = new StringBuilder();
        private static StringBuilder Path = new StringBuilder();
        private static Boolean IsValidCommand()
        {
            Attributes.Append(CommandParser.ExtractAtributes(CommandParser.FullPath));
            Path.Append(CommandParser.ExtractPath(CommandParser.FullPath));
            if (!Path.Equals("") || !Attributes.Equals("") || CommandParser.IsThereRemainingCommandsInTheString(CommandParser.FullPath))
            {
                Console.WriteLine("This clear doesn't take any arguments.");
                Attributes.Clear();
                Path.Clear();
                return false;
            }
            return true;
        }
        public static void Clear()
        {
            if(IsValidCommand())
            {
                for (int i = 0; i < 30; i++)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
