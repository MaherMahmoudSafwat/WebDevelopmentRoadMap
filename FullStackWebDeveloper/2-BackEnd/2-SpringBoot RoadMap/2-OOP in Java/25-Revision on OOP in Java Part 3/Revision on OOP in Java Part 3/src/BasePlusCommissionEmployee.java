public class BasePlusCommissionEmployee extends CommissionEmployee
{
    private double base;

    public double getBase() {
        return base;
    }

    public void setBase(double base) {
        this.base = base;
    }

    @Override
    public double earnings()
    {
        return base + super.earnings();
    }

    @Override
    public void DisplayAllDetails()
    {
        super.DisplayAllDetails();
    }

    @Override
    public void DisplayEarnings()
    {
        System.out.println("Earnings = " + earnings());
    }
}
