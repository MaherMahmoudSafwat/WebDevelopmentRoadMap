namespace Random_App_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please choose [1]Random Numbers Generator\t[2]Random Strings Generator");
                string UserChoice = Console.ReadLine();
                if (UserChoice == "1")
                {
                    Console.Write("Enter min number :- ");
                    int Number1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter max number :- ");
                    int Number2 = int.Parse(Console.ReadLine());
                    RandomNumberGenerator(Number1, Number2);
                }
                else if (UserChoice == "2")
                {
                    Console.Write("Enter length of the string :- ");
                    int Length = int.Parse(Console.ReadLine());
                    RandomStringGenerator(Length);
                }
            } 
        }
        public static void RandomNumberGenerator(int num1, int num2)
        {
            Random Rnd = new Random();
            var RandomNumber = Rnd.Next(num1, num2);
            Console.WriteLine(RandomNumber);
        }
        public static void UserChoice(out bool CapitalLetters,out bool SmallLetters,out bool IncludeNumbers, out bool IncludeSymbols)
        {
            Console.Write("Would you like to include capital letters ? yes/no ?");
            CapitalLetters = (Console.ReadLine().ToUpper() == "YES") ? true : false;
            Console.Write("Would you like to include small letters ? yes/no ?");
            SmallLetters = (Console.ReadLine().ToUpper() == "YES") ? true : false;
            Console.Write("Would you like to include numbers ? yes/no ?");
            IncludeNumbers = (Console.ReadLine().ToUpper() == "YES") ? true : false;
            Console.Write("Would you like to include symbols ? yes/no ?");
            IncludeSymbols = (Console.ReadLine().ToUpper() == "YES") ? true : false;
        }
        public static void RandomStringGenerator(int Length)
        {
            string RandomString = "";
            Random Rnd = new Random();
            int RandomNumber = 0;
            int RandomNumbers2 = 0;
            bool CapitalLetters, SmallLetters, IncludeNumbers, IncludeSymbols;
            UserChoice(out CapitalLetters,out SmallLetters,out IncludeNumbers,out IncludeSymbols);
            while (RandomString.Length < Length)
            {
                RandomNumber = Rnd.Next(1, 5);
                if(RandomNumber == 1)
                {
                    if(CapitalLetters)
                    {
                        RandomString += (char)(Rnd.Next(65, 91));
                    }
                }
                else if(RandomNumber == 2)
                {
                    if(SmallLetters)
                    {
                        RandomString += (char)(Rnd.Next(97, 123));
                    }
                }
                else if(RandomNumber == 3)
                {
                    if(IncludeNumbers)
                    {
                        RandomString += (char)(Rnd.Next(48, 58));
                    }
                }
                else if(RandomNumber == 4)
                {
                    if(IncludeSymbols)
                    {
                        RandomNumbers2 = Rnd.Next(1, 5);
                        if (RandomNumbers2 == 1)
                            RandomString += (char)(Rnd.Next(32, 48));
                        else if (RandomNumbers2 == 2)
                            RandomString += (char)(Rnd.Next(58, 65));
                        else if (RandomNumbers2 == 3)
                            RandomString += (char)(Rnd.Next(91, 97));
                        else
                            RandomString += (char)(Rnd.Next(123, 127)); 
                    }
                }
            }
            Console.WriteLine(RandomString);
        }
    }
}
