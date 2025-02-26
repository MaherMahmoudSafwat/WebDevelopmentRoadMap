using System.Net.Sockets;

namespace Constant_Read_Only
{
    internal class Program
    {
        //The Const Variable.
        //The const is a keyword that is used to assign a value to a variable at the same line and can't be changed.
        //The const keyword can be used with string class and any other primitive datatype but it can't be used with classes rather than string.
        //You can't use a static keyword with const keyword.
        //At the compile time compiler replace all constants variables with it is values.
        public const string Name = "Maher";

        //The read-only variable.
        //The readonly keyword can be used with a variable to assign a value to it at the same line or in a constructor.
        //You can assign a value to a readonly variable in a constructor multiple times and more than once.
        //At run time  Compiler replace all readonly variables with it is values only at runtime when it sees the variable.
        public static readonly string Address;

        static Program()
        {
            Address = "Faisal";
            Address = "Giza";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Name);
            //Name = "Samir"; Not allowed because Name is a Constant Variable.
            //Address = "Faisal"; Not allowed because Address is a Readonly Variable. 
            Console.WriteLine(Address);        
        }
    }
}
