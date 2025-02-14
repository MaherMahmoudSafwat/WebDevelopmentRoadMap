namespace Static_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Student = new Student1();
            Student.PrintName();
            //Student.PrintYpourSpecification();Not allowed because PrintYpourSpecification is a static method.
            Student1.PrintYpourSpecification();
            Console.WriteLine(Student2.Name());
            Student2.Name();
            Student2.Name();
            Student2.Name();
            Student2.Name();
            Student2.Name();
            Student2.Name();
            Student2.Name();
            Console.WriteLine(Student2.Counter);//8
        }
    }
}
