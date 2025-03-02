namespace Recursion
{
    internal class Program
    {
        // Recursion in C# refers to a method calling itself to solve a problem.
        // It is used to break down complex problems into smaller subproblems.
        // Every recursive function must have a base case to stop infinite recursion.
        // Without a base case, recursion will lead to a StackOverflowException.
        // Recursion is commonly used in problems like factorial calculation, Fibonacci series, and tree traversal.
        
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
