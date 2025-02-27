namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var HR = new HR();
            HR.SetName("Mohammed", "Ahmed");
            HR.SetDateBirth(new DateOnly(2000, 1, 1));
            HR.BasicSalary = -5000;
            HR.TaxSalary = 140;
            Console.WriteLine($"Full Name:\t{HR.FirstName} {HR.LastName}");
            Console.WriteLine($"Birth Date:\t{HR.BirthDate}");
            Console.WriteLine($"Basic Salary:\t{HR.BasicSalary}0:00");
            Console.WriteLine($"Tax Salary:\t{HR.TaxSalary}%");
            Console.ReadKey();
        }
    }
}
