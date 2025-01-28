using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name1 = "Maher";
            Name1 = "Hello Maher";
            //String here is immutable as you have reserved three spaces inside the memory.
            Name1 += " , i love C#";
            Console.WriteLine(Name1);

            //So to overcome the immutable problem use the stringbuilder.
            StringBuilder Name2 = new StringBuilder(4096);
            Console.WriteLine(Name2.Length);
            Console.WriteLine(Name2.Capacity);
            Name2.Append("Hello ");
            Name2.Append("World");
            Console.WriteLine(Name2.ToString());
            Console.WriteLine(Name2.Length);
            Console.WriteLine(Name2.Capacity);
            Name2.AppendLine(" I love programming");
            Console.WriteLine(Name2.ToString());
            Console.WriteLine(Name2.Length);
            Console.WriteLine(Name2.Capacity);
            Console.WriteLine(Name2.MaxCapacity);
        }
    }
}
