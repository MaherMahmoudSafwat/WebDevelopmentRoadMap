//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        Rectangle R1 = new Rectangle(10, 20, 30, 3, 50);
        //The method getArea is overridden then it will implement the content of what is found in rectangle class not in the shape class.
        System.out.println(R1.getArea());

        Square S1 = new Square(10, 20, 30, 3, 50);
        System.out.println(S1.getArea());

        R1.Print_All_Details();

        // Polymorphism in Java

        // A Shape reference (R2) is pointing to a Rectangle object.
        Shape R2 = new Rectangle(10, 20, 30, 3, 50);
        // Calling the method Print_All_Details() on the Shape reference R2.
        // This will call the overridden method in Rectangle (if it's overridden).
        R2.Print_All_Details();

        // Attempting to call CalculatePerimeter() on R2 will cause an error if
        // CalculatePerimeter() is not defined in the Shape class or overridden in Rectangle.
        // R2's reference type is Shape, so it only knows about methods in Shape.
        // This will give a compile-time error because the method is not available in Shape.
        //R2.CalculatePerimeter(); // Error: Not Allowed.

        // You cannot create a Rectangle object and assign it to a Shape reference directly.
        // A Rectangle is a subclass of Shape, but Shape is not a subclass of Rectangle.
        // You cannot assign a parent class reference to a child class variable.
        // This will result in a compile-time error.
        //Rectangle R3 = new Shape(10,20,30,3); // Error: Not Allowed.
    }
}