using System.Globalization;

namespace StringFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String Format
            string FullName = "My name is {0} and my brother name is {1} and im {0}";
            Console.WriteLine(FullName, "Maher", "Safwat");
            FullName = "{1}";
            Console.Write(FullName, "Maher", "Safwat");//Print Safwat
            //Control Spacing
            //Space occurs to left from right
            FullName = "My name is {0,15}{1,12}{2,17}";
            Console.WriteLine(FullName, "Maher", "Mahmoud", "Safwat");
            //Format Argument
            double Salary = 10000;
            string Str = "My Salary is {0:C3}";
            Str = string.Format(Str, Salary);
            Console.WriteLine(Str);
            //If you don't want the Dollar sign or any Curency Sign use N instead of C
            Str = "My Salart is {0:N0}";
            Str = string.Format(Str, Salary);
            Console.WriteLine(Str);
            Str = "My Salart is {0:N5}";
            Str = string.Format(Str, Salary);
            Console.WriteLine(Str);
            //If you don't want Currency Sign And Cooma Between Numbers, you only want The Deciamls After Number Use 0.0
            Str = "My Salart is {0:0.000}";
            Str = string.Format(Str, Salary);
            Console.WriteLine(Str);
            //To Convert from any Data Type To String Use ToString()
            int X = 5;
            String S = X.ToString();
            Console.WriteLine(S);
        }
    }
}
