namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Percentage = -100;
            if (Percentage.IsRangeInBetween(0,100))
                Console.WriteLine("valid Percentage.");
            else
                Console.WriteLine("Invalid Percentage.");
        }
    }
}
