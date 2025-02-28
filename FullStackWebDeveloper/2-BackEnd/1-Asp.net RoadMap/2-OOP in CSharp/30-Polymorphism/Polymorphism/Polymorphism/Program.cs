namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dynamic Polymorphism.
            var SalariedEmployee = new SalariedEmployee();
            SalariedEmployee.BasicSalary = 2000;
            SalariedEmployee.Housing = 1000;
            SalariedEmployee.Transportation = 3000;
            Console.WriteLine($"Salary of Salaried Employee Without Tax is {SalariedEmployee.GetSalary():0.00}");
            Console.WriteLine($"Salary of Salaried Employee with Tax is {SalariedEmployee.GetSalary(333):0.00}");

            var HourlyEmployee = new HourlyEmployee();
            HourlyEmployee.HourRate = 1000;
            HourlyEmployee.TotalWorkingHours = 3000;
            Console.WriteLine($"Salary of Salaried Employee is {HourlyEmployee.GetSalary():0.00}");

            var IntentEmployee = new IntentEmployee();
            Console.WriteLine($"Salary of Salaried Employee is {IntentEmployee.GetSalary():0.00}");
        }
    }
}
