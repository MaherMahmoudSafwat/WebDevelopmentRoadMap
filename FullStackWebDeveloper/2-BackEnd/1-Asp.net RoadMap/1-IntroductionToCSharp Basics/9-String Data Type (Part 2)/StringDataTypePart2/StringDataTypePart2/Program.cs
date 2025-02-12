namespace StringDataTypePart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "John";
            Console.WriteLine(Name);
            Console.WriteLine("Please enter your name: ");
            //ReadLine() method reads the next line of characters from the standard input stream
            string Name1 = Console.ReadLine();
            Console.WriteLine($"My name is {Name1}");
            //length property returns the number of characters in the string
            Console.WriteLine($"The length of the string is {Name1.Length}");
            //Upper method converts the string to uppercase
            Console.WriteLine($"UpperCase : {Name1.ToUpper()}");
            //Lower method converts the string to lowercase
            Console.WriteLine($"LowerCase : {Name1.ToLower()}");
            //Starts with method checks whether the string starts with the specified character or string
            Console.WriteLine($"Starts with 'J' : {Name1.StartsWith("J")}");
            Console.WriteLine($"Starts with 'm' : {Name1.StartsWith("m")}");
            Console.WriteLine($"Starts with 'M' : {Name1.StartsWith("M")}");
            //String Comparsion is used to help to ignore the case of the string while comparing two strings
            Console.WriteLine($"Starts with 'm' : {Name1.StartsWith("m", StringComparison.OrdinalIgnoreCase)}");
            Console.WriteLine($"Starts with 'mAh' : {Name1.StartsWith("mAh", StringComparison.OrdinalIgnoreCase)}");
            //Ends with method checks whether the string ends with the specified character or string
            Console.WriteLine($"Ends with 'n' : {Name1.EndsWith("n")}");
            Console.WriteLine($"Ends with 'he' : {Name1.EndsWith("he")}");
            Console.WriteLine($"Ends with 'er' : {Name1.EndsWith("er")}");
            Console.WriteLine($"Ends with 'er' : {Name1.EndsWith("er")}",StringComparison.OrdinalIgnoreCase);
            Console.WriteLine($"Ends with 'r' : {Name1.EndsWith("r",StringComparison.OrdinalIgnoreCase)}");
            //Contains method checks whether the string contains the specified character or string
            Console.WriteLine($"Contains 'o' : {Name1.Contains("o")}");
            Console.WriteLine($"Contains 'Er' : {Name1.Contains("Er")}");
            Console.WriteLine($"Contains 'Er' : {Name1.Contains("Er",StringComparison.OrdinalIgnoreCase)}");
            //IndexOf method returns the index of the first occurrence of the specified character or string
            Console.WriteLine($"Index of 'o' : {Name1.IndexOf("o")}");
            Console.WriteLine($"Index of 'e' : {Name1.IndexOf("e")}");
            Console.WriteLine($"Index of 'E' : {Name1.IndexOf("E")}");
            Console.WriteLine($"Index of 'E' : {Name1.IndexOf("E", StringComparison.OrdinalIgnoreCase)}");
            Name1 = "Debbuger";
            //LastIndexOf method returns the index of the last occurrence of the specified character or string
            Console.WriteLine($"Last Index of 'e' : {Name1.LastIndexOf("e")}");
            Console.WriteLine($"Last Index of 'E' : {Name1.LastIndexOf("E")}");
            Console.WriteLine($"Last Index of 'E' : {Name1.LastIndexOf("E", StringComparison.OrdinalIgnoreCase)}");
            Console.WriteLine($"Index of 'er' : {Name1.LastIndexOf("er")}");
            //Remove method removes all the characters from the string from the specified index to specified index length
            Console.WriteLine($"Erase : {Name1.Remove(1,2)}");
            //Replace method replaces the specified character or string with another character or string
            Console.WriteLine($"Replace : {Name1.Replace("e", "")}");
            Console.WriteLine($"Replace : {Name1.Replace("E", "a")}");
            Console.WriteLine($"Replace : {Name1.Replace("e", "a",StringComparison.OrdinalIgnoreCase)}");
            //Substring method returns the substring from the specified index to the end of the string
            Console.WriteLine($"Substring : {Name1.Substring(1,5)}");
        }
    }
}
