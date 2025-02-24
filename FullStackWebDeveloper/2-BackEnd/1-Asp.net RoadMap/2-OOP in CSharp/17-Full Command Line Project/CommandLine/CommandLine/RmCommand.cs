using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLine
{
    class RmCommand
    {
        private static StringBuilder Attributes = new StringBuilder();
        private static StringBuilder Path = new StringBuilder();
        private static bool IsValidCommand()
        {
            Attributes.Append(CommandParser.ExtractAtributes(CommandParser.FullPath));
            Path.Append(CommandParser.ExtractPath(CommandParser.FullPath));
            if (Attributes.Equals("") || Path.Equals(""))
            {
                Console.WriteLine("rm Commands need at least two Argument.");
                Attributes.Clear();
                Path.Clear();
                return false;
            }
            if (CommandParser.IsThereRemainingCommandsInTheString(CommandParser.FullPath))
            {
                Console.WriteLine("The system can't find the specified path.");
                Attributes.Clear();
                Path.Clear();
                return false;
            }
            return true;
        }
        private static void DeleteFilesOnly()
        {
            string FullPath = Program.FullPathName.Substring(0,Program.FullPathName.Length-1) + "\\" + Path.ToString();
            if (File.Exists(FullPath))
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                File.Delete(FullPath);
                Console.WriteLine("File has bee deleted Successfully.");
            }
            else
            {
                Console.WriteLine("The system can't find the specified path.");
            }
        }
        private static void DeleteDirectoriesOnly()
        {
            string FullPath = Program.FullPathName.Substring(0, Program.FullPathName.Length - 1) + "\\" + Path.ToString();
            if (Directory.Exists(FullPath))
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                Directory.Delete(FullPath);
                Console.WriteLine("Directory has bee deleted Successfully.");
            }
            else
            {
                Console.WriteLine("The system can't find the specified path.");
            }
        }
        public static void Rm()
        {
            if(IsValidCommand())
            {
                if (Attributes.Equals("-f"))
                {
                    DeleteFilesOnly();
                }
                else if (Attributes.Equals("-d"))
                {
                    DeleteDirectoriesOnly();
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
