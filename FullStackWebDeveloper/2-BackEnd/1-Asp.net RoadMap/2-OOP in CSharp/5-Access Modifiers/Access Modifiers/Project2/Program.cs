using Student;
namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello c#");
            Student1 S1 = new Student1();
            Student2 S2 = new Student2();//Allowed because it is on the same project. 
        }
    }
}
