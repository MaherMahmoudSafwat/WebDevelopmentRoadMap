using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLine
{
    class EchoCommand
    {
        private static bool IsValidCommand()
        {
            if (CommandParser.FullPath == "")
            {
                Console.WriteLine("The Echo Commands need at least one Argumrnt.");
                return false;
            }
            return true;
        }
        public static void Echo()
        {
            CommandParser.FullPath = CommandParser.FullPath.Substring(4).Trim();
            if(IsValidCommand())
            {
                Console.WriteLine(CommandParser.FullPath);
            }
        }
    }
}
