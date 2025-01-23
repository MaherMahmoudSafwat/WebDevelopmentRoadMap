//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args)
    {
        Rectangle R1 = new Rectangle(10,20,30,3,40);
        //Rectangle will inherit the getArea method normally but it can't override it as the method in parent class is final
        System.out.println(R1.getArea());

        Square S1 = new Square(10,20,30,3,40);
        // Calling the method 'length' or getLength() method which accesses the protected member from the Parent class
        System.out.println(S1.length);
    }
}
