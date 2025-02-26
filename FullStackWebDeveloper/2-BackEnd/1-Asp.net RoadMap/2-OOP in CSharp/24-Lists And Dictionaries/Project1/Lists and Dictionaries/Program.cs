namespace Lists_and_Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Difference between List<T> and ArrayList in C#

            // 1. Type Safety:
            //    - List<T> is strongly typed, meaning it only holds a specific data type.
            //    - ArrayList stores elements as objects, requiring boxing/unboxing for value types.

            // 2. Performance:
            //    - List<T> is faster because it avoids boxing/unboxing overhead.
            //    - ArrayList is slower due to the need for type conversions.

            // 3. Generic vs Non-Generic:
            //    - List<T> is a generic collection introduced in .NET 2.0.
            //    - ArrayList is a non-generic collection from older .NET versions.

            // 4. Type Casting:
            //    - List<T> does not require type casting when retrieving elements.
            //    - ArrayList requires explicit type casting, increasing the risk of runtime errors.

            // 5. Preferred Usage:
            //    - List<T> is recommended for new applications due to better performance and type safety.
            //    - ArrayList is considered outdated and is mostly replaced by List<T>.
            //Strong data type. 
            List<int>Lists = new List<int>();
            Lists.Add(1);
            //Lists.Add("Test");This is not allowed. 
            Lists.Capacity=20000000;
            Lists.AddRange(new int[] { 1, 2, 3 });
            Console.WriteLine(Lists[0]);
            foreach (int i in Lists)
            {
                Console.WriteLine(i);
            }
            Lists.Remove(5);
            Lists.RemoveAt(2);
            foreach (int i in Lists)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(Lists.Contains(3));

            // Dictionary in C#

            // 1. A Dictionary is a collection that stores key-value pairs.
            // 2. Each key in the dictionary must be unique, while values can be duplicated.
            // 3. It provides fast lookups, additions, and deletions based on keys.
            // 4. The keys and values must have specified data types, like Dictionary<int, string>.
            // 5. It uses a hashing mechanism for efficient data retrieval.
            // 6. Dictionary does not maintain any specific order of elements.
            // 7. If a key does not exist and is accessed, it throws a KeyNotFoundException.
            // 8. Methods like Add(), Remove(), TryGetValue(), and ContainsKey() are commonly used.
            // 9. It is useful when data needs to be mapped in a key-value format for quick access.

            //var Dict = new Dictionary<string, string>();
            Dictionary<string, string> Dict = new Dictionary<string, string>();
            Dict.Add("Gmail","Maher");
            Console.WriteLine(Dict["Gmail"]);
            //Dict.Add("Gmail", "C#");This is not Allowed.
            Dict["Gmail"] = "Mse";
            Console.WriteLine(Dict["Gmail"]);
            if (Dict.ContainsKey("Gmail"))
                Dict.Add("OutLook", "PWD");
            Dict.Add("Yahoo", "Maher");
            Dict.Add("Twitter", "X");
            Dict.Add("Skype", "Caller");
            Dict.Add("Youtube", "Maher");
            Dict.Add("Facebook", "Readers");
            foreach (KeyValuePair<string,string> i in Dict)
            {
                Console.WriteLine($"key is {i.Key} and value is {i.Value}");
            }
        }
    }
}
