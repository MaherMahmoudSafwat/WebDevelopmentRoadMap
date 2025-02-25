namespace Member_Hiding_and_Shadowing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape S1 = new Rectangle();
            S1.PrintArea();
            Rectangle Rect = new Rectangle();
            Rect.PrintArea();
        }
    }
}
