using Student;
namespace Access_Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Student1 S1 = new Student1();
            S1.id = 5;
            //Student2 S2 = new Student2();//Not allowed because class is internal. 
            Student2 S2 = new Student2();
            //S2.id Not allowed because id it is internal. 
        }
    }
}
