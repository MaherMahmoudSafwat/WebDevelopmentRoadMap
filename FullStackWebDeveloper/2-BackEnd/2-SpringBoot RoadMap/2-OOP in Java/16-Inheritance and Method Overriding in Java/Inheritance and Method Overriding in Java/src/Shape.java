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

    public void Print_All_Details()
    {
        System.out.println("Length is :- " + getLength());
        System.out.println("Perimeter is :- " + getPerimeter());
        System.out.println("Area is :- " + getArea());
        System.out.println("Dimensions are :- " + getDimensions());
    }
}