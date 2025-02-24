using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLine
{
    class DateCommand
    {
        private static StringBuilder Attributes = new StringBuilder();
        private static StringBuilder Path = new StringBuilder();
        private static Boolean IsValidCommand()
        {
            Attributes.Append(CommandParser.ExtractAtributes(CommandParser.FullPath));
            Path.Append(CommandParser.ExtractPath(CommandParser.FullPath));
            if (Attributes.Equals(""))
            {
                Console.WriteLine("Date Commands need at least one Argument.");
                Attributes.Clear();
                Path.Clear();
                return false;
            }
            if (CommandParser.IsThereRemainingCommandsInTheString(CommandParser.FullPath) || !Path.Equals(""))
            {
                Console.WriteLine("The system can't find the specified path.");
                Attributes.Clear();
                Path.Clear();
                return false;
            }
            return true;
        }
        private static void ReadAllDate(DateTime AllDateTime)
        {
            Console.WriteLine(AllDateTime);
        }
        private static void ReadDateOnly(DateTime Date)
        {
            Console.WriteLine("The date is {0:MM-dd-yyyy}", Date);
        }
        private static void ReadTimeOnly(DateTime Time)
        {
            Console.WriteLine("The time is {0:HH:mm:ss tt}", Time);
        }
        public static void Date()
        {
            if(IsValidCommand())
            {
                DateTime DateTime = new DateTime();
                DateTime = DateTime.Now;
                if (Attributes.Equals("-All"))
                {
                    ReadAllDate(DateTime);
                }
                else if (Attributes.Equals("-date"))
                {
                    ReadDateOnly(DateTime);
                }
                else if (Attributes.Equals("-time"))
                {
                    ReadTimeOnly(DateTime);
                }
                else
                {
                    Console.WriteLine("Invalid Arguments, Please try again.");
                }
            }
            Attributes.Clear();
            Path.Clear();
        }
    }
}
