using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CommandLine
{
    class AllCommandsMethodsHandler
    {
        public static void Touch()
        {
            TouchCommand.Touch();
        }
        public static void Mkdir()
        {
            MkdirCommand.Mkdir();
        }
        public static void Clear()
        {
            ClearCommand.Clear();
        }
        public static void Reset()
        {
            ResetCommand.Reset();
        }
        public static void Cd()
        {
            CdCommand.Cd();
        }
        public static void History()
        {
            HistoryCommand.History();
        }
        public static void Date()
        {
            DateCommand.Date();
        }
        public static void Rm()
        {
            RmCommand.Rm();
        }
        public static void List()
        {
            ListCommand.List();
        }
        public static void Echo()
        {
            EchoCommand.Echo();
        }
    }
}
