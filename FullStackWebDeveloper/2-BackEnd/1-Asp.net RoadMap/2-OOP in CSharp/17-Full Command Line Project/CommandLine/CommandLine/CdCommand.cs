using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLine
{
    class CdCommand
    {
        private static StringBuilder Attributes = new StringBuilder();
        private static StringBuilder Path = new StringBuilder();
        private static Boolean IsValidCommand()
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
                Console.WriteLine("This Cd Commands takes 1 Argument Only.");
                Attributes.Clear();
                Path.Clear();
                return false;
            }
            if (Path.Equals("") && Attributes.Equals(""))
            {
                Console.WriteLine("This Cd Commands takes 1 Argument Only.");
                Attributes.Clear();
                Path.Clear();
                return false;
            }
            if (Path.Equals("\\") || Path.Equals("/"))
            {
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
        private static void CdContainsDot()
        {
            if (Program.FullPathName == "C:\\>")
            {
                return;
            }
            if (Path.ToString().Length == 3)
            {
                if (Path.ToString().Substring(0, 3) == "\\..")
                {
                    Program.FullPathName = "C:\\>";
                    return;
                }
            }
            while (Path.ToString().Contains(".."))
            {
                if (Program.FullPathName == "C:>")
                {
                    Program.FullPathName = "C:\\>";
                    break;
                }
                Program.FullPathName = Program.FullPathName.ToString().Remove(Program.FullPathName.ToString().LastIndexOf('\\')) + ">";
                string p = Path.ToString().Remove(Path.ToString().LastIndexOf(".."));
                Path.Clear();
                Path.Append(p);
            }
            if (Program.FullPathName == "C:>")
            {
                Program.FullPathName = "C:\\>";
            }
        }
        private static string CommandPath()
        {
            string FullPath = "";
            if (Program.FullPathName == "C:\\>")
            {
                if (Path.ToString()[0] == '\\')
                {
                    FullPath = Program.FullPathName.Substring(0, Program.FullPathName.Length - 1) + Path.ToString().Substring(1);
                }
                else
                {
                    FullPath = Program.FullPathName.Substring(0, Program.FullPathName.Length - 1) + Path.ToString().Substring(0);
                }
            }
            else
                FullPath = Program.FullPathName.Substring(0, Program.FullPathName.Length - 1) + "\\" + Path.ToString();
            return FullPath;
        }
        private static void CdDoesntContainsDot(string FullPath)
        {
            if (FullPath.Contains('/'))
            {
                StringBuilder SB = new StringBuilder();
                SB.Append(FullPath);
                if (FullPath[3] == '/')
                {
                    FullPath = Utility.ReplaceFirst(SB, '/', ' ').ToString();
                }
                FullPath = FullPath.Replace('/', '\\');
                SB.Clear();
            }
            if (FullPath[FullPath.Length - 1] == '\\')
            {
                FullPath = FullPath.Substring(0, FullPath.Length - 1);
            }
            if (FullPath.Contains("\\\\"))
            {
                Console.WriteLine("The system can't find the specified path.");
                return;
            }
            if (System.IO.Path.Exists(FullPath))
            {
                Program.FullPathName = FullPath + ">";
            }
            else
            {
                Console.WriteLine("The system can't find the specified path.");
            }
        }
        public static void Cd()
        {
            if(IsValidCommand())
            {
                if (Path.ToString().Contains(".."))
                {
                    CdContainsDot();
                }
                else
                {
                    string FullPath = CommandPath();
                    CdDoesntContainsDot(FullPath);
                }
            }
            Attributes.Clear();
            Path.Clear();
        }
    }
}
