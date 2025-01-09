namespace StringSpiltAndJoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Spilt
            Console.Write("Please enter a string Seperated by a Comma.\n");
            string Input = Console.ReadLine();
            // The Split() method divides a string into an array of substrings based on a specified delimiter.
            // In this case, the string "Input" is split wherever a comma (",") is found.
            // Example: If Input = "apple,banana,grape", the result is an array: ["apple", "banana", "grape"].
            string[] StringArray = Input.Split(",");
            int Sum = 0;
            foreach (string number in StringArray)
            {
                Sum += int.Parse(number);
            }
            Console.WriteLine($"Average of the numbers is {Sum / StringArray.Length}");
            
            //Join
            // The Join() method combines elements of an array into a single string, with a specified separator between each element.
            // In this case, the elements of the "Array" are joined into a string, with " , " (comma and space) as the separator.
            // Example: If Array = ["apple", "banana", "grape"], the result will be: "apple , banana , grape".
            string[] Array = ["Apple", "Banana", "Orange"];
            string Str = string.Join(" , ",Array);
            Console.WriteLine(Str);
        }
    }
}
