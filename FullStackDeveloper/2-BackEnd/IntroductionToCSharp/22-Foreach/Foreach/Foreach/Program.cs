namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach loop is used to iterate through a collection of items such as an array or list.
            //It is a more concise موجزة way to loop through a collection than using a for loop.
            //foreach loop is read-only, meaning you cannot modify the collection you are iterating over.
            int[] numbers = { 1, 2, 3, 4, 5 };
            int i = 0;
            foreach (int number in numbers)
            {
                System.Console.WriteLine(number);
            }

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach(char vowel in vowels)
            {
                // (int)vowel is used to convert char to int to get the ASCII value of the character.
                System.Console.WriteLine($"{vowel} is {(int)vowel}");
            }
        }
    }
}
