public class SalariedEmployee extends Employee implements Displayable
{
    double Salary,Bonus,Deductions;

    public double getSalary() {
        return Salary;
    }

    public void setSalary(double salary) {
        Salary = salary;
    }

    public double getBonus() {
        return Bonus;
    }

    public void setBonus(double bonus) {
        Bonus = bonus;
    }

    public double getDeductions() {
        return Deductions;
    }

    public void setDeductions(double deductions) {
        Deductions = deductions;
    }

    public SalariedEmployee(double salary, double bonus, double deductions , String Name, String Address, int SSN, Gender Sex)
    {
        super(Name,Address,SSN,Sex);
        Salary = salary;
        Bonus = bonus;
        Deductions = deductions;
    }
    @Override
    public double earnings()
    {
        return (Salary + Bonus) - Deductions;
    }
    @Override
    public void DisplayAllDetails()
    {
        System.out.println(super.toString());
    }

    @Override
    public String toString() {
        return "SalariedEmployee{" +
                "Salary=" + Salary +
                ", Bonus=" + Bonus +
                ", Deductions=" + Deductions +
                '}';
    }

    @Override
    public void DisplayEarnings()
    {
        System.out.println(toString());
    }
}

