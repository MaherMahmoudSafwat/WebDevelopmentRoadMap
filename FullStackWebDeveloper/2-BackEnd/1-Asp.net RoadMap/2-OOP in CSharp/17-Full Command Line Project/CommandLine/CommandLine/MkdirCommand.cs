using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLine
{
    class MkdirCommand
    {
        private static StringBuilder Attributes = new StringBuilder();
        private static StringBuilder Path = new StringBuilder();
        private static bool IsValidCommand()
        {
            Attributes.Append(CommandParser.ExtractAtributes(CommandParser.FullPath));
            Path.Append(CommandParser.ExtractPath(CommandParser.FullPath));
            if (Path.Equals("") && !Attributes.Equals(""))
            {
                Path.Append(Attributes);
                Attributes.Clear();
            }
            if (!Path.Equals("") && !Attributes.Equals(""))
            {
                Console.WriteLine("This Mkdir Commands takes 1 Argument Only.");
                Attributes.Clear();
                Path.Clear();
                return false;
            }
            if (Path.Equals("") && Attributes.Equals(""))
            {
                Console.WriteLine("This Mkdir Commands takes 1 Argument Only.");
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
        private static string CommandPath()
        {
            string FullPath = "";
            if (Program.FullPathName == "C:\\>")
            {
                FullPath = Program.FullPathName.Substring(0, Program.FullPathName.Length - 1) + Path.ToString();
            }
            else
            {
                FullPath = Program.FullPathName.Substring(0, Program.FullPathName.Length - 1) + "\\" + Path.ToString();
            }
            return FullPath;
        }
        public static void Mkdir()
        {
            if (IsValidCommand())
            {
                string FullPath = CommandPath();
                if (Directory.Exists(FullPath))
                {
                    Console.WriteLine("Directory is Already Exists.");
                    return;
                }
                try
                {
                    try
                    {
                        Directory.CreateDirectory(FullPath);
                        Console.WriteLine("Directory had been Created Successfully.");
                    }
                    catch
                    {
                        throw new Exception("Error File.");
                    }
                }
                catch
                {
                    Console.WriteLine("The system can't find the specified path.");
                }
                finally
                {
                    Attributes.Clear();
                    Path.Clear();
                }
            }
        }
    }
}
