public class Rectangle extends Shape {
    double Width;

    Rectangle(double L, double P, double A, int D, double Width) {
        //Is not a good way of coding and bad use of Reusability.
        /*
        length = L;
        perimeter = P;
        Area = A;
        Dimensions = D;
        */

        //Use Super to call the Constructor of the main class
        super(L, P, A, D);

        this.Width = Width;
    }

    public void setWidth(double width) {
        Width = width;
    }

    public double getWidth() {
        return Width;
    }

    //Override annotation is used to override the method content in the parent class and implement the method content of the child class.
    //Override is used a method has the same signature and found in parent class and you want to edit it in the child class.
    /*
    The @Override annotation in Java provides the following benefits:
    Prevents errors by ensuring correct method overriding.
    Improves readability by explicitly marking overridden methods.
    Enhances maintainability by providing compile-time checks when the superclass method changes.
    Prevents accidental method creation with the same name but incorrect signatures.
    Supports polymorphism by enforcing proper overriding for dynamic method dispatch.
    */
    @Override
    public double getArea()
    {
        return length*Width;
    }

    @Override
    public void Print_All_Details()
    {
        /*
        In Java, super is a keyword used to refer to the parent class (superclass) of the current object. It serves a few key purposes:
        Accessing Parent Class Methods: You can use super to call a method from the parent class, especially if the method is overridden
        in the subclass.
        Accessing Parent Class Constructor: super() is used in the subclass constructor to invoke the constructor of the parent class,
        ensuring that the parent class is properly initialized.
        Accessing Parent Class Variables: If a subclass has a variable with the same name as the parent class variable, super can be used
        to access the parent class's version of the variable.
        In summary, super helps a subclass to interact with or refer to its parent class, allowing you to access or call its methods,
        constructors, and variables.
        */
        /*
        super is related to the superclass (parent class). It allows a subclass to access or refer to members (methods, variables, constructors)
        of its superclass.
        In simple terms:super is used to refer to the superclass from within the subclass.
        */
        super.Print_All_Details();
        System.out.println("Width is " + getWidth());
    }
    public double CalculatePerimeter()
    {
        return perimeter;
    }
}