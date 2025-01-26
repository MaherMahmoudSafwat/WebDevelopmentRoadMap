import java.util.Scanner;//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args)
    {
        int Var1=4;
        double Var2=20.5;
        double Var3 = Var1 * (0.5 * Var2);
        System.out.println("Var3 equal :" + Var3 + "\n iam a good programmer $$$");

        System.out.println("Enter Weight in Pounds");
        Scanner Input = new Scanner(System.in);
        double weightinpounds = Input.nextDouble();
        double weightinkgs = weightinpounds * 0.454;
        System.out.println("The weight in pounds : " + weightinpounds + " = " + weightinkgs + " Kilo grams");

        System.out.println("Enter Hours");
        int hours = Input.nextInt();

        System.out.println("Enter Minutes");
        int minutes = Input.nextInt();

        System.out.println("Enter seconds");
        int seconds = Input.nextInt();

        int timeinseconds = (hours * 60 * 60) + (minutes * 60) + seconds;
        System.out.println("Time  in seconds " + timeinseconds);

        final int transportation = 600;
        System.out.println("Enter Basic Salary");
        double basicsalary = Input.nextDouble();
        double allowance = 0;
        if(basicsalary >=15000)
            allowance = basicsalary * 0.05;
        else if (basicsalary >= 10000 && basicsalary <=14999)
            allowance = 0.10;
        else if (basicsalary >= 5000 && basicsalary <=9999)
            allowance = 0.15;
        else allowance=0.20;

        double netsalary = transportation + basicsalary + (basicsalary  * allowance);
        System.out.println("The Net Salary = " + netsalary);
    }
}