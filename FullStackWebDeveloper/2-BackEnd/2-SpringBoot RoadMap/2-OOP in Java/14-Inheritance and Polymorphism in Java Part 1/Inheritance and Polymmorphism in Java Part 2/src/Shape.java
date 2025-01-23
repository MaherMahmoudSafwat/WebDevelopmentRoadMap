public class Shape
{
    double length;
    double Area;
    double perimeter;
    int Dimensions;
    Shape()
    {
        //Constructor SuperClass is Executed first before the SubClass.
        System.out.println("Hello, I'm The constructor of the Base Class that is called Shape");
    }
    Shape(double Length, double Area, double Perimeter, int Dimensions)
    {
        length = Length;
        this.Area = Area;
        this.perimeter = Perimeter;
        this.Dimensions = Dimensions;
    }

    public void setLength(double length) {
        this.length = length;
    }

    public double getLength() {
        return length;
    }

    public void setArea(double area) {
        Area = area;
    }

    public double getArea() {
        return Area;
    }

    public void setPerimeter(double perimeter) {
        this.perimeter = perimeter;
    }

    public double getPerimeter() {
        return perimeter;
    }

    public int getDimensions() {
        return Dimensions;
    }

    public void setDimensions(int dimensions) {
        Dimensions = dimensions;
    }
}
public class Rectangle extends Shape
{
    double Width;
    Rectangle (double L, double P , double A, int D, double Width)
    {
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

}
public class Square extends Shape
{
    double Diagnols;

    Square()
    {
        System.out.println("Hello There, I'm the Constructor of the Derived Class that is called Square.");
    }
    Square(double L, double A, double P, int D, double Diagnols)
    {
        super(L,A,P,D);
        this.Diagnols = Diagnols;
    }

    public void setDiagnols(double diagnols) {
        Diagnols = diagnols;
    }

    public double getDiagnols() {
        return Diagnols;
    }
}
