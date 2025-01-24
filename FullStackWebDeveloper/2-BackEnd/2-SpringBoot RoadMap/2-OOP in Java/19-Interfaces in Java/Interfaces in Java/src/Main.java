//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args)
    {
        //Shape S1 = new Shape(); Not Allowed As you can't get an instance or object from an interfaces class.
        Rectangle R1 = new Rectangle();
        R1.setLength(10);
        R1.setWidth(20);
        System.out.println(R1.getArea());
        System.out.println(R1.getPerimeter());
        R1.DisplayResults();

        //So you can make a reference variable of interface class and points to object of a child class
        Shape S1 = new Square();
        //S1 will only implement the methods that are found in both shape interface class and Square child class.
        /*But if the method is found only in Square class it won't implement it or call it here in main and
         the same applies to normal and abstract classes
        */
        System.out.println(S1.getArea());
        System.out.println(S1.getPerimeter());
    }
}