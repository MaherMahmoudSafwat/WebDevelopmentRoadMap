using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLine
{
    class TouchCommand
    {
        private static StringBuilder Attributes =new StringBuilder();
        private static StringBuilder Path = new StringBuilder();
        private static Boolean IsValidCommandLine()
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
                Console.WriteLine("This Touch Commands takes 1 Argument Only.");
                Attributes.Clear();
                Path.Clear();
                return false;
            }
            if (Path.Equals("") && Attributes.Equals(""))
            {
                Console.WriteLine("This Touch Commands takes 1 Argument Only.");
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
        public static void Touch()
        {
            if(IsValidCommandLine())
            {
                string FullPath = CommandPath();
                if (File.Exists(FullPath))
                {
                    Console.WriteLine("File is Already Exists.");
                }
                else
                {
                    try
                    {
                        try
                        {
                            File.Create(FullPath);
                            Console.WriteLine("File had been Created Successfully.");
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
                }
                Attributes.Clear();
                Path.Clear();
            }
        }
    }
}
