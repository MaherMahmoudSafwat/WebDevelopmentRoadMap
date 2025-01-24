//The interface class acts as a contract class.
public interface Shape
{
    //The private and protected access modifiers members are not allowed in The Interfaces Class.
    //private double Area = 5; Not Allowed
    //protected double Area1 = 5;Not Allowed

    //Any Member in interface class must be public and final.
    public double length = 8;
    public double Area = 5;
    public double Perimeter = 9;

    //Constructors are not allowed in interfaces Class.
    /* Shape()
    {

    }*/
    //There is no way  you can create and implement a body code in methods inside interfaces classes as this is not allowed in interfaces class.
    double getArea();
    double getPerimeter();
}
