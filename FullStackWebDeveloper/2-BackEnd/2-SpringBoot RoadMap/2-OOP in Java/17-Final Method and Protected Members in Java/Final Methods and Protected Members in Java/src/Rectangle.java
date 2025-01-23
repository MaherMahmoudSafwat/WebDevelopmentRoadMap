public class Rectangle extends Shape {
    double Width;

    Rectangle(double L, double P, double A, int D, double Width) {

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

    /*@Override
    public double getArea()
    {
        return length*length;
    }*///Not Allowed As getArea method is now final
}