using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        public static string MergeAlternately(string word1, string word2)
        {
            StringBuilder sb = new StringBuilder();
            if (word1.Length == word2.Length)
            {
                for(int i = 0;i<word1.Length;i++)
                {
                    sb.Append(word1[i]);
                    sb.Append(word2[i]);
                }
            }
            else if (word1.Length < word2.Length)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    sb.Append(word1[i]);
                    sb.Append(word2[i]);
                }
                for(int i = word1.Length;i<word2.Length;i++)
                {
                    sb.Append(word2[i]);
                }
            }
            else if(word1.Length > word2.Length)
            {
                for(int i =0;i<word2.Length;i++)
                {
                    sb.Append(word1[i]);
                    sb.Append(word2[i]);
                }
                for(int i=word2.Length;i<word1.Length;i++)
                {
                    sb.Append(word1[i]);
                }
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MergeAlternately("abcd", "qr"));
        }
    }
}
