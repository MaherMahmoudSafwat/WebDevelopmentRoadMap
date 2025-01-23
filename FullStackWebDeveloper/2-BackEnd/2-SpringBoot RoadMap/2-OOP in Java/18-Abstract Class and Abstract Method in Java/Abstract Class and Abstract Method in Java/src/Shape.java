//Abstract class can't be instantiated , it means you can't create an object from it the main class.
public abstract class Shape
{
    protected double Length;
    protected double Area;
    protected double Perimeter;

    Shape()
    {

    }
    Shape(double Length, double Area, double Perimeter)
    {
        this.Length = Length;
        this.Area = Area;
        this.Perimeter = Perimeter;
    }

    public void setLength(double length) {
        Length = length;
    }

    public double getLength() {
        return Length;
    }

    public void setArea(double area) {
        Area = area;
    }

    //Abstract method can't have body and should implemented by child classes inherits from this abstract class
    //Abstract methods are used only in abstract classes.
    //Abstract method has no body
    public abstract double getArea();

    public void setPerimeter(double perimeter) {
        Perimeter = perimeter;
    }

    public double getPerimeter() {
        return Perimeter;
    }
}
