//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args)
    {
        Rectangle R1 = new Rectangle(10,30,40,2,3);
        System.out.println(R1.getLength());
        System.out.println(R1.getPerimeter());
        System.out.println(R1.getArea());
        System.out.println(R1.getDimensions());
        System.out.println(R1.getWidth());

        //The Constructor of the Base Class is Executed First.
        Square S1 = new Square();
    }
}