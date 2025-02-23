using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLine
{
    public class CommandParser
    {
        private static int i = 0;
        public static string FullPath;
        public static string ExtractCommand(string FullUserPath)
        {
            FullUserPath = FullUserPath.Trim();
            string Token = "";
            for(int j = 0;j<FullUserPath.Length;j++)
            {
                if (FullUserPath[j] == ' ')
                {
                    break;
                }
                Token += FullUserPath[j];
                i = j;
            }
            FullPath = FullUserPath;
            return Token;
        }
        public static string ExtractAtributes(string FullUserPath)
        {
            FullUserPath = FullUserPath.Substring(i+1);
            FullUserPath = FullUserPath.Trim();
            string Token = "";
            for(int j =0;j<FullUserPath.Length;j++)
            {
                if (FullUserPath[j]==' ')
                {
                    break;
                }
                Token += FullUserPath[j];
                i = j;
            }
            FullPath = FullUserPath;
            return Token;
        }
        public static string ExtractPath(string FullUserPath)
        {
            if (FullUserPath == "")
                return "";
            FullUserPath = FullUserPath.Substring(i+1);
            FullUserPath = FullUserPath.Trim();
            string Token = "";
            for(int j=0;j<FullUserPath.Length;j++)
            {
                if (FullUserPath[j]==' ')
                {
                    break;
                }
                Token += FullUserPath[j];
                i = j;
            }
            FullPath = FullUserPath;
            return Token;
        }
        public static Boolean IsThereRemainingCommandsInTheString(string FullUserPath)
        {
            FullUserPath = FullUserPath.Trim();
            int Counter = 0;
            string[] StringSpilter = FullUserPath.Split();
            foreach(string i in StringSpilter)
            {
                if (i == "" || i == " ")
                    continue;
                Counter++;
            }
            return Counter > 1;
        }
        public static void CommandsLinePrompt(string Token)
        {
            try
            {
                switch ((Commands)Enum.Parse(typeof(Commands), Token))
                {
                    case Commands.touch:
                        AllCommandsMethodsHandler.Touch();
                        break;
                    case Commands.mkdir:
                        AllCommandsMethodsHandler.Mkdir();
                        break;
                    case Commands.clear:
                        AllCommandsMethodsHandler.Clear();
                        break;
                    case Commands.reset:
                        AllCommandsMethodsHandler.Reset();
                        break;
                    case Commands.cd:
                        AllCommandsMethodsHandler.Cd();
                        break;
                    case Commands.history:
                        AllCommandsMethodsHandler.History();
                        break;
                    case Commands.date:
                        AllCommandsMethodsHandler.Date();
                        break;
                    case Commands.rm:
                        AllCommandsMethodsHandler.Rm();
                        break;
                    case Commands.list:
                        AllCommandsMethodsHandler.List();
                        break;
                    case Commands.echo:
                        AllCommandsMethodsHandler.Echo();
                        break;
                }
            }
            catch(ArgumentOutOfRangeException Ex)
            {
                Console.WriteLine($"{Token} Command needs one Argument.");
            }
            catch(Exception Ex)
            {
                Console.WriteLine($"{Token} is not recognized as an internal or external command," +
                    $"\noperable program or batch file.\a");
            }
        }
    }
}
