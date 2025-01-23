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

    // The 'Child' class extends the 'Parent' class, so it can access the 'protected' member 'length'
    public double GetLength()
    {
        return length;
    }
}
