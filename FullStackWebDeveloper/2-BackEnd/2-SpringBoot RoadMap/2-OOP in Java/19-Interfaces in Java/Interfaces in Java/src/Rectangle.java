//You can in java implements more than one interfaces class but you can't extend (multiple classes) more than one class or abstract class.
public class Rectangle implements Shape,Display
{
    double length;
    double Width;

    public void setLength(double length) {
        this.length = length;
    }

    public double getLength() {
        return length;
    }

    public void setWidth(double width) {
        Width = width;
    }

    public double getWidth() {
        return Width;
    }

    public double getArea()
    {
        return length*Width;
    }
    public double getPerimeter()
    {
        return 2*(length+Width);
    }
    public void DisplayResults()
    {
        System.out.println("Length of Rectangle is " + length + " and Width of the Rectangle is " + Width +
                " and final Area in Shape and Rectangle is " + Area);
    }
}
