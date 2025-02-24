using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLine
{
    class ListCommand
    {
        private static StringBuilder Attributes = new StringBuilder();
        private static StringBuilder Path = new StringBuilder();
        private static Boolean IsValidCommand()
        {
            Attributes.Append(CommandParser.ExtractAtributes(CommandParser.FullPath));
            Path.Append(CommandParser.ExtractPath(CommandParser.FullPath));
            if (Attributes.Equals("") || Path.Equals(""))
            {
                Console.WriteLine("List Commands need at least two Argument.");
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
        private static void ListFilesDataOnly()
        {
            string FullPath = Program.FullPathName.Substring(0, Program.FullPathName.Length - 1) + "\\" + Path.ToString();
            if (File.Exists(FullPath))
            {
                FileInfo FilePath = new FileInfo(FullPath);
                Console.WriteLine("Type : File");
                Console.WriteLine($"Created At : {FilePath.CreationTime}");
                Console.WriteLine($"Last Modified At : {FilePath.LastAccessTime}");
                Console.WriteLine($"Last Write Time At : {FilePath.LastWriteTime}");
                Console.WriteLine($"Size in Bytes is : {FilePath.Length}");
            }
            else
            {
                Console.WriteLine("The system can't find the specified path.");
            }
        }
        private static void ListDirectoriesDataOnly()
        {
            string FullPath = Program.FullPathName.Substring(0, Program.FullPathName.Length - 1) + "\\" + Path.ToString();
            if (Directory.Exists(FullPath))
            {
                DirectoryInfo DirectoryPath = new DirectoryInfo(FullPath);
                Console.WriteLine("Type : Directory");
                Console.WriteLine($"Created At : {DirectoryPath.CreationTime}");
                Console.WriteLine($"Last Modified At : {DirectoryPath.LastAccessTime}");
                Console.WriteLine($"Last Write Time At : {DirectoryPath.LastWriteTime}");
                Console.WriteLine("Files in Directory : ");
                foreach (FileInfo i in DirectoryPath.GetFiles())
                    Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("The system can't find the specified path.");
            }
        }
        public static void List()
        {
            if(IsValidCommand())
            {
                if (Attributes.Equals("-f"))
                {
                    ListFilesDataOnly();
                }
                else if (Attributes.Equals("-d"))
                {
                    ListDirectoriesDataOnly();
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
