namespace DateTimeClass
{
    internal class Program
    {
        /*struct C
        {
            public static int x { set; get; }

        }*/
        static void Main(string[] args)
        {
            //To get the Time Now.
            DateTime Date = DateTime.Now; 
            Console.WriteLine(Date);
            Console.WriteLine(Date.Year);
            Console.WriteLine(Date.Month);
            Console.WriteLine(Date.Day);
            Console.WriteLine(Date.Hour-12);
            Console.WriteLine(Date.Minute);
            Console.WriteLine(Date.Second);
            Console.WriteLine(Date.ToString());
            Console.WriteLine(Date.AddHours(12));
            Console.WriteLine(Date.AddTicks(100));
            Console.WriteLine(Date.DayOfWeek);
            Console.WriteLine(Date.TimeOfDay);
            Console.WriteLine("Date is {0:dddd-MMMM-yyyy h:m:s tt}", Date);
            Date = new DateTime(2025,3,4,3,3,3);
            Console.WriteLine(Date);
            //------------------------------------------------------
            DateOnly DateOnly = new DateOnly(2025, 2, 18);
            Console.WriteLine(DateOnly);
            Console.WriteLine(DateOnly.Day);
            DateOnly = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(DateOnly);
            //======================================================
            TimeOnly TimeOnly = new TimeOnly(11, 11, 11);
            Console.WriteLine(TimeOnly);
            TimeOnly EvenIn = new TimeOnly(8,30);
            TimeOnly EvenOut = new TimeOnly(21, 30);
            var TotalTimeWorked = EvenIn - EvenOut; //This var is a datatype called TimeSpan.
            Console.WriteLine(TotalTimeWorked.TotalHours);
        }
    }
}
