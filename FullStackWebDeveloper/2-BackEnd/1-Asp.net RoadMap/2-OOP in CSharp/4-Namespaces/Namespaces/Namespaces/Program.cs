using Namespaces;
using Z;
using Student = Namespaces.Student;
//You can aso use alias.
using ZStudent = Z.Student;
internal class Program
{
    static void Main(string[] args)
    {
        //In case of Ambiguouity use Namespace Name to identify the namespace of the class you points to it.
        Student S = new Namespaces.Student();
        S.Id = 5;
        Z.Student S2 = new Z.Student();
        S2.Name = "Maher";
        ZStudent S3 = new Z.Student();
        Employee Employee = new Employee();
        Employee.nationalName = "Ms";
        Console.WriteLine(Employee.nationalName); 
    }
}

