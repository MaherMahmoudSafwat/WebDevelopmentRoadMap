namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Employee = new Employee();
            Employee.SetName("Mohammed", "Ahmed");
            Employee.SetDateBirth(new DateOnly(2000, 1, 1));
            Employee.BasicSalary = -5000;
            Employee.TaxPercentage = 140;

            PrintPersonDetails(Employee);
            Console.WriteLine("----------------------");
            var Applicant = new Applicant();
            Applicant.SetName("Mohammed", "Abbas");
            Applicant.SetDateBirth(new DateOnly(2004, 5, 20));
            PrintPersonDetails(Applicant);
            Person Person = Employee;
            Person = Applicant; 

            Console.WriteLine($"Basic Salary:\t{Employee.BasicSalary}0:00");
            Console.WriteLine($"Tax Salary:\t{Employee.TaxPercentage}%");
            Console.ReadKey();
        }
        static void PrintPersonDetails(Person Person)
        {
            Console.WriteLine($"Full Name:\t{Person.FirstName} {Person.LastName}");
            Console.WriteLine($"Birth Date:\t{Person.BirthDate}");
        }
    }
}
