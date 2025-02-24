namespace File_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write(">>");
                var input = Console.ReadLine().Trim();
                var whiteSpaceIndex = input.IndexOf(' ');
                var command = input.Substring(0, whiteSpaceIndex).ToLower();
                var path = input.Substring(whiteSpaceIndex + 1).Trim();

                if (command == "list")
                {
                    foreach (var entry in Directory.GetDirectories(path))
                        Console.WriteLine($"\t[Diry] {entry}");
                    foreach (var entry in Directory.GetFiles(path))
                        Console.WriteLine($"\t[File] {entry}");
                }
                else if (command == "info")
                {
                    if (Directory.Exists(path))
                    {
                        var dirInfo = new DirectoryInfo(path);
                        Console.WriteLine("Type: Directory");
                        Console.WriteLine($"Created At: {dirInfo.CreationTime}");
                        Console.WriteLine($"Last Modified At: {dirInfo.LastWriteTime}");
                    }
                    else if (File.Exists(path))
                    {
                        var fileInfo = new FileInfo(path);
                        Console.WriteLine("Type: File");
                        Console.WriteLine($"Created At: {fileInfo.CreationTime}");
                        Console.WriteLine($"Last Modified At: {fileInfo.LastWriteTime}");
                        Console.WriteLine($"Size in Bytes:{fileInfo.Length}");
                    }
                }
                else if (command == "mkdir")
                {
                    Directory.CreateDirectory(path);
                }
                else if (command == "remove")
                {
                    if (Directory.Exists(path))
                        Directory.Delete(path);
                    else if (File.Exists(path))
                        File.Delete(path);
                }
                else if (command == "print")
                {
                    if (File.Exists(path))
                    {
                        var Content = File.ReadAllText(path);
                        Console.WriteLine(Content);
                    }
                }
                else if (command == "exit")
                    break;
            }
        }
    }
}
