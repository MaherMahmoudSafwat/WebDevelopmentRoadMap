import javax.sound.midi.SysexMessage;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args)
    {
        Department d1 = new Department(1,"Information Systems");

        SalariedEmployee se = new SalariedEmployee(2000,500,50,"Ahmed","Riyadh",1200,Gender.Male);
        d1.add_employee(se);

        HourlyEmployee he = new HourlyEmployee(100,6,"Mohammed","Kharj",1500,Gender.Male);
        d1.add_employee(he);

        CommissionEmployee ce = new CommissionEmployee(15000,0.25,"Fatema","Riyadh",1200,Gender.Female);

        System.out.println(d1.getemployeecount());

        d1.print_basic_data();
        d1.print_All_details();
    }
}