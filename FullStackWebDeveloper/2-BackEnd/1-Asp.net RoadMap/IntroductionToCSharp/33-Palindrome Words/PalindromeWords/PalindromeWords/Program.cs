namespace PalindromeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Please enter a string to check if it is Palindrome or not : ");
                string Word = Console.ReadLine();
                Boolean IsPalindrome = true;
                for (int i = 0;i < Word.Length/2;i++)
                {
                    if (char.ToUpper(Word[i]) != char.ToUpper(Word[Word.Length-i-1]))
                    {
                        IsPalindrome = false;
                        break;
                    }
                }
                Console.WriteLine($"Is Palindrome :- {IsPalindrome}");
            }
        }
    }
}
