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
