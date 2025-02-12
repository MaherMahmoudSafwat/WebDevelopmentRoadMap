using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Anagram Solver");
            string[] ScrambedWords = new string[7];
            string[] RearrangedWords = new string[7];
            ScrambedWords = ArrayOfScrambedWords(ScrambedWords);
            RearrangedWords = ArrayOfRearrangedWords(ScrambedWords);
            Result(AnagramSolver(ScrambedWords, RearrangedWords));

        }
        /// <summary>
        /// Take arrays of non-aranged and reaggranded Words
        /// </summary>
        /// <param name="ScramvedWords"></param>
        /// <param name="RearrangedWords"></param>
        static string[] ArrayOfScrambedWords(string[] ScrambedWords)
        {
            ScrambedWords = new string[] { "Alpep", "Tac", "Cogelle", "Starm", "Ropgaingmmr", "Ousem", "Trabeyrrws" };
            return ScrambedWords;
        }
        static string[] ArrayOfRearrangedWords(string[] RearrangedWords)
        {
            RearrangedWords = new string[] { "Apple", "Cat", "College", "Smart", "Programming", "Mouse", "Strawberry" };
            return RearrangedWords;
        }
        static int AnagramSolver(string[] ScramdedWords, string[] RearrandedWords)
        {
            int Counter = 0;
            int i = 0;
            while (i < 7)
            {
                Console.WriteLine("Rearrange the Following Word:- ");
                StringBuilder sb = new StringBuilder();
                Console.WriteLine($"The Word is :- {ScramdedWords[i]}");
                sb.Append(Console.ReadLine());
                if (sb.ToString().ToUpper() == RearrandedWords[i].ToUpper())
                {
                    Console.WriteLine("Correct, Excellent :-)");
                    Counter++;
                }
                else
                {
                    Console.WriteLine("Wrong Answer :-(");
                }
                i++;
            }
            return Counter;
        }
        static void Result(int Counter)
        {
            if (Counter < 3)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You lost :-(");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("You won :-)");
            }
        }
    }
}
