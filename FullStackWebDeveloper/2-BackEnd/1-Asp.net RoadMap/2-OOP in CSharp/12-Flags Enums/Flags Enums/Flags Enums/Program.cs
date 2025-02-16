namespace Flags_Enums
{
    // The [Flags] attribute allows an enum to be treated as a bit field,
    // meaning its values can be combined using bitwise operators.
    // This is useful for scenarios where multiple values need to be stored in a single variable.

    // This attribute enables bitwise combinations for the enum values.
    [Flags]
    enum WeekDays
    {
        None = 0,      //0b_0000_0000
        Saturday = 1,  //0b_0000_0001
        Sunday = 2,    //0b_0000_0010
        Monday = 4,    //0b_0000_0100
        Tuesday = 8,   //0b_0000_1000
        Wednesday = 16,//0b_0001_0000
        Thursday = 32, //0b_0010_0000
        Friday = 64    //0b_0100_0000
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bitwise Operators are | , & , ~, ^ 
            // Bitwise | Operator is used to collect all items in one enum and used to store in one variable 
            WeekDays WeekEnds = WeekDays.Friday | WeekDays.Saturday | WeekDays.Monday;
            WeekDays WeekDays1 = WeekDays.Saturday | WeekDays.Thursday | WeekDays.Wednesday;
            WeekDays WeekDays2 = WeekEnds | WeekDays1;
            Console.WriteLine(WeekDays2);
            // Bitwise & Operator is used to get the common items between two enums.
            WeekEnds = WeekDays.Friday & WeekDays.Saturday & WeekDays.Monday;
            Console.WriteLine(WeekEnds);
            WeekEnds = WeekDays.Friday | WeekDays.Saturday | WeekDays.Monday;
            WeekDays1 = WeekDays.Saturday | WeekDays.Thursday | WeekDays.Wednesday;
            WeekDays2 = WeekEnds & WeekDays1;
            Console.WriteLine(WeekDays2);
            // Bitwise ~ Operator is used to store all enums values expect the wanted excluded value you want to exclude.
            WeekDays2 = (WeekEnds & ~WeekDays.Monday);
            Console.WriteLine(WeekDays2);
            // Bitwise ^ Operator is used to add an enum value if you want to toggled it , if it's found it will remove it and if it doesn't found it it will add it. 
            WeekDays2 = WeekEnds ^ WeekDays.Saturday;
            Console.WriteLine(WeekDays2);
            WeekDays2 = WeekEnds ^ WeekDays.Sunday;
            Console.WriteLine(WeekDays2);
        }
    }
}
