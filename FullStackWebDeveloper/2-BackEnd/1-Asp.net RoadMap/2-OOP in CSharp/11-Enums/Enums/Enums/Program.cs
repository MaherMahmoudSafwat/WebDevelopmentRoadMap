using System.Drawing;

namespace Enums
{
    internal class Program
    {
        //Simple enum.
        enum Gender
        {
            Male,
            Female = 2
        /*public static void x()
        {

        }*///Not Allowed.
        }
        public enum Colors
        {
            Green,
            Yellow,
            Red,
            Magenta,
            Brown,
            Blue,
            White
        }
        static void Main(string[] args)
        {
            /* Gender gender = Gender.Male;
             Console.WriteLine(gender);
             Console.ForegroundColor = ConsoleColor.Red;
            */
            string ColorType = "RED";
            Colors Color = Colors.Blue;
            // Enum.GetNames() is a method that retrieves the names of all the constants
            // in the specified enum as an array of strings.

            // typeof(Colors) is used to get the Type object for the Colors enum.
            // This tells Enum.GetNames() to look at the Colors enum and get all its names.
            foreach (var color in Enum.GetNames(typeof(Colors)))
            {
                //Console.WriteLine($"{color} = {(int)color}");Not Allowed
                // (int)Enum.Parse(typeof(Colors), color) explained:

                // 1. typeof(Colors):
                //    - Gets the Type object for the Colors enum.
                //    - This tells Enum.Parse() which enum to inspect.
                //    - In this case, it's saying: "Look at the Colors enum."

                // 2. Enum.Parse(typeof(Colors), color):
                //    - Tries to convert the string 'color' to an enum value.
                //    - Here, 'color' is "Green", which matches the 'Green' constant in Colors.
                //    - Enum.Parse() finds this match and returns Colors.Green.
                //    - The return value is of type object, but it represents Colors.Green.

                // 3. (int) - Casting to Integer:
                //    - Colors.Green is an enum constant with an underlying value of 2.
                //    - By casting it to int, we get the numeric value associated with Colors.Green.
                //    - So, (int)Colors.Greenbecomes 2.

                Console.WriteLine($"{color} = {(int)Enum.Parse(typeof(Colors), color)}");
            }
            Color = (Colors)Enum.Parse(typeof(Colors), ColorType,true);
            Console.WriteLine($"{Color} = {(int)Color}");


            //----------------------------------------------
            //Exercise.
            while(true)
            {
                Console.WriteLine("Please select an option: )");
                Console.WriteLine("[1] Change Background Color\t\t[2]Change Foreground Color");
                string SelectedOption = Console.ReadLine();
                foreach (var color in Enum.GetNames(typeof(ConsoleColor)))
                    Console.WriteLine($"{color}");
                Console.Write("Please enter the color name: ");
                string ColorName = Console.ReadLine();
                ConsoleColor selectedColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor),ColorName,true);
                if(SelectedOption == "1")
                {
                    Console.BackgroundColor = selectedColor;
                }
                else if (SelectedOption == "2")
                {
                    Console.ForegroundColor = selectedColor;
                }
                else
                {
                    Console.WriteLine("Invalid Option");
                }
            }
        }
    } 
}
