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
