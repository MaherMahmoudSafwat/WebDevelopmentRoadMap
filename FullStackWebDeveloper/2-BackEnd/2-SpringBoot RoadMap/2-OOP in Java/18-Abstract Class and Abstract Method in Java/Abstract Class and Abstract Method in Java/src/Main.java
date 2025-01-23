//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args)
    {
        //Shape S1 = new Shape(); Error Not Allowed as you can't get an object from the abstract class
        Rectangle R1 = new Rectangle();
        R1.setLength(10);
        R1.setWidth(20);
        System.out.println(R1.getArea());
        Square S1 = new Square();
        S1.setLength(10);
        System.out.println(S1.getArea());
    }
}