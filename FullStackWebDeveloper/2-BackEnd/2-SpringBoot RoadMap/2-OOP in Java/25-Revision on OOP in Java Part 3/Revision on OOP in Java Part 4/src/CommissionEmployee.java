public class CommissionEmployee extends Employee implements Displayable
{
    private double gross_sales;
    private double commission_rate;

    public double getGross_sales() {
        return gross_sales;
    }

    public void setGross_sales(double gross_sales) {
        this.gross_sales = gross_sales;
    }

    public double getCommission_rate() {
        return commission_rate;
    }

    public void setCommission_rate(double commission_rate) {
        this.commission_rate = commission_rate;
    }

    CommissionEmployee(double gross_sales, double commission_rate,String Name, String Address, int SSN, Gender Sex)
    {
        super(Name,Address,SSN,Sex);
        this.gross_sales = gross_sales;
        this.commission_rate = commission_rate;
    }
    @Override
    public double earnings()
    {
        return gross_sales*commission_rate;
    }

    @Override
    public String toString() {
        return "CommissionEmployee{" +
                "gross_sales=" + gross_sales +
                ", commission_rate=" + commission_rate +
                '}';
    }

    @Override
    public void DisplayEarnings()
    {
        System.out.println(earnings());
    }

    @Override
    public void DisplayAllDetails()
    {
        System.out.println(super.toString());
        System.out.println(toString());
    }
}
