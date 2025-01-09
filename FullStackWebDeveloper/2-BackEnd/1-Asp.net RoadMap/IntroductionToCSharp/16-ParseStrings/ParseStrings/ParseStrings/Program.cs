namespace ParseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parsing a string to an integer
            Console.WriteLine("Please Enter a Number or anything :- ");
            //Converts the string representation of a number to its 32-bit signed integer equivalent.
            //Parse method is used to convert a string to an integer or any other desired data type.
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine($"You have entered {Number}");

            //only + can be used in string to concatenate the string and variables and in numeric values it will add the values.
            //string N = "5" + "10"; //510
            string N = "5" + 10f;//510
            Console.WriteLine(N);
        }
    }
}
