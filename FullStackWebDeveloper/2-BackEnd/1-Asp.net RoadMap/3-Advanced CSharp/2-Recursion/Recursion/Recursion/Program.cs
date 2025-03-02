namespace Recursion
{
    internal class Program
    {
        static long CalculateDirectorySize(string dirpath)
        {
            long Size = 0;
            foreach(var FileName in Directory.GetFiles(dirpath))
            {
                Size += new FileInfo(FileName).Length;
            }
            foreach(var DirectoryName in Directory.GetDirectories(dirpath))
            {
                Size += CalculateDirectorySize(DirectoryName);
            }
            return Size;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateFactorial(5)); 
            Console.WriteLine(CalculateDirectorySize("C:\\Users\\Maher\\Desktop\\WebDevelopmentRoadMap\\FullStackWebDeveloper\\2-BackEnd")/1024);
        }
        static int CalculateFactorial(int number)
        {
            if (number <= 1)
                return number;
            return number * CalculateFactorial(number - 1);
        }
    }
}
