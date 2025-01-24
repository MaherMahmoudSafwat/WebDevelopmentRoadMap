//You can't extend more than one class whether it is normal classes or abstract classes.
//public class Rectangle extends Shape,Display //Not allowed as Rectangle can't extend more than one class from parent classes. 
public class Rectangle extends Shape
{
    private double Width;

    public void setWidth(double width) {
        Width = width;
    }

    public double getWidth() {
        return Width;
    }

    @Override
    public double getArea()
    {
        return Length*Width;
    }
}
