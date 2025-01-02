namespace Switch_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if else statement example
            while (true)
            {
                Console.Write("Enter the string :- ");
                string input = Console.ReadLine();
                Console.WriteLine("Please Choose one of the following :- ");
                Console.WriteLine("1.Print string in Capital Letters.");
                Console.WriteLine("2.Print string in Small Letters.");
                Console.WriteLine("3.Print Length of the string.");
                string SelectedOption = Console.ReadLine();
                if (SelectedOption == "1")
                {
                    Console.WriteLine(input.ToUpper());
                }
                else if (SelectedOption == "2")
                {
                    Console.WriteLine(input.ToLower());
                }
                else if (SelectedOption == "3")
                {
                    Console.WriteLine(input.Length);
                }
                else
                {
                    Console.WriteLine("Invalid Option");
                }
            }
            //Switch statement example
            while (true)
            {
                Console.Write("Enter the string :- ");
                string input = Console.ReadLine();
                Console.WriteLine("Please Choose one of the following :- ");
                Console.WriteLine("1.Print string in Capital Letters.");
                Console.WriteLine("2.Print string in Small Letters.");
                Console.WriteLine("3.Print Length of the string.");
                string SelectedOption = Console.ReadLine();
                switch (SelectedOption)
                {
                    case "1":
                        Console.WriteLine(input.ToUpper());
                        break;
                    case "2":
                        Console.WriteLine(input.ToLower());
                        break;
                    case "3":
                        Console.WriteLine(input.Length);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                        //Default case can be in the first or last position or in between the cases.
                }
            }
            while (true)
            {
                Console.Write("Enter the string :- ");
                string input = Console.ReadLine();
                Console.WriteLine("Please Choose one of the following :- ");
                Console.WriteLine("1.Print string in Small Letters.");
                Console.WriteLine("2.Print string in Small Letters.");
                Console.WriteLine("3.Print Length of the string.");
                string SelectedOption = Console.ReadLine();
                switch (SelectedOption)
                {
                    //You can use multiple cases for a single block of code.
                    case "1":
                    case "2":
                        Console.WriteLine(input.ToLower());
                        break;
                    case "3":
                        Console.WriteLine(input.Length);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                        // Default case can be in the first or last position or in between the cases.
                }
            }
        }
    }
}
