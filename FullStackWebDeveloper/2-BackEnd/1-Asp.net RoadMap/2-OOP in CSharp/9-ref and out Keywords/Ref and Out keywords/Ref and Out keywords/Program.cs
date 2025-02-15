using System.Security.Cryptography;
using System.Xml.Serialization;

namespace Ref_and_Out_keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            Duplicate(x);
            Console.WriteLine($"X = {x}");
            /*
             1-ref :- you must initalize the variable and assign a value to it before you use it with the ref, but you have the choice and option not to
             use the ref variable inside the method.
             2-out :- you you have the option and choice to not assign a value to the out variable in the initalization time, but you must assign a value 
             to it when using the out variable in the method.
             3-In all cases , :- ref and out keywords both of them pass by reference.
            */
            TestRef();
            TestOut();
            //int num = 0; 
            bool isSuccessful = true;
            Console.Write("Please enter a number :- ");
            //num = int.Parse(Console.ReadLine()); /if inputs a word or a string.
            isSuccessful = int.TryParse(Console.ReadLine(), out int num);
            Console.WriteLine($"isSuccessful = {isSuccessful}");
            Console.WriteLine($"result = {num}");
        }
        static void TestRef()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            bool isSuccessful = true;
            var result = Divide(5, 0, ref isSuccessful);
            Console.WriteLine($"isSuccessful = {isSuccessful}");
            Console.WriteLine($"result = {result}");
        }
        static void TestOut()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            bool isSuccessful = true;
            var result = DivideOut(5, 0, out isSuccessful);
            Console.WriteLine($"isSuccessful = {isSuccessful}");
            Console.WriteLine($"result = {result}");
        }
        static void Duplicate(int x)//x=x
        {
            x = 5;
        }
        static double Divide(int number,int divisor,ref bool isSuccessful)
        {
            if(divisor==0)
            {
                Console.WriteLine("can't divide on Zero !");
                isSuccessful = false;
                return 0;
            }
            isSuccessful = true;
            return number / divisor;
        }
        static double DivideOut(int number, int divisor, out bool isSuccessful)
        {
            if (divisor == 0)
            {
                Console.WriteLine("can't divide on Zero !");
                isSuccessful = false;
                return 0;
            }
            isSuccessful = true;
            return number / divisor;
        }
    }
}
