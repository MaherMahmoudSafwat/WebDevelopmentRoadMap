namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Do while loop is used when we want to execute the block of code at least once and then check the condition.
            int x = 1;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x <= 5);
            //While loop is used when we want to execute the block of code only if the condition is true.
            int y = 1;
            while (y <= 5)
            {
                Console.WriteLine(y);
                y++;
            }
            //infinite loop using while loop
            while(true)
            {
                Console.WriteLine("Please enter a string to Capitalize or press Exit to exit :- ");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    //break statement is used to exit the loop.
                    break;
                }
                else
                {
                    Console.WriteLine(input.ToUpper());
                }
            }
        }
    }
}
