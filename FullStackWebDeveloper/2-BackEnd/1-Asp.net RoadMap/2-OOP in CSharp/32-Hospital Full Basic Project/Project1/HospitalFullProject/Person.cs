using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalFullProject
{
    public abstract class Person
    {
        public int _ID { get; set; }
        protected static string _FirstName;
        protected static string _LastName;
        protected static string _Email;
        protected static string _Password;
        public static void SetName()
        {
            bool IsNullOrWhiteSpace = true;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t\t\t\t\tUser Name"); 
                Console.WriteLine("Please enter your First name :- ");
                _FirstName = Console.ReadLine();
                Console.WriteLine("Please enter your Last Name :- ");
                _LastName = Console.ReadLine();
                IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(_FirstName) || string.IsNullOrWhiteSpace(_LastName);
                if (IsNullOrWhiteSpace)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid First Name or LastName, Please try again");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (IsNullOrWhiteSpace);
        }
        public static void SetEmail()
        {
            bool IsNullOrWhiteSpace = true;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t\t\t\t\tUser Name");
                Console.WriteLine("Please enter your First name :- ");
                _FirstName = Console.ReadLine();
                Console.WriteLine("Please enter your Last Name :- ");
                _LastName = Console.ReadLine();
                IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(_FirstName) || string.IsNullOrWhiteSpace(_LastName);
                if (IsNullOrWhiteSpace)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Email, Please try again");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (IsNullOrWhiteSpace);
        }
        public static void SetPassword()
        {
            bool IsNullOrWhiteSpace = true;
            string SpeciaCharacters = "!@#$%|&()";
            bool IsStringContainsSpecialCharacters = true;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t\t\t\t\tUser Password");
                Console.WriteLine("Please enter your Password :- ");
                _Password = Console.ReadLine();
                IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(_FirstName) || string.IsNullOrWhiteSpace(_LastName);
                IsStringContainsSpecialCharacters = !Utility.IsSpecialCharactersFound(_Password, SpeciaCharacters);
                if (IsNullOrWhiteSpace)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Password, Please try again");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                if(IsStringContainsSpecialCharacters)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Password must contains at least one Special Character, Please try again");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            } while (IsNullOrWhiteSpace || IsStringContainsSpecialCharacters);
        }
    }
}
