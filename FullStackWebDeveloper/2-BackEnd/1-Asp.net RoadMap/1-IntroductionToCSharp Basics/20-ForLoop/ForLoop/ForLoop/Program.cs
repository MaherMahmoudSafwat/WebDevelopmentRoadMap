namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For loop is used to iterate a block of code a specified number of times.
            // The syntax of for loop is:
            // for (initialization; condition; increment/decrement)
            int x = 5;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"x{i + 1} :- {x}");
            }
            //To loop in an array we can use for loop.
            int[] Numbers = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine($"Numbers{i} is {Numbers[i]}");
            }
            //Exercise 1
            char Ch = 'A';
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine(Ch);
                //To increment the character we can use the following code.
                //Ch++ will convert the character to its ASCII value and then increment it by 1 and then convert it back to character.
                Ch++;
            }
            //Exercise 2 
            Console.WriteLine("Please enter five numbers :- ");
            int[] Numbers1 = new int[5];
            for(int i = 0; i < Numbers1.Length; i++)
            {
                Numbers1[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(Numbers1);
            for (int i =0;i < Numbers1.Length; i++)
            {
                Console.WriteLine(Numbers1[i]);
            }
        }
    }
}
