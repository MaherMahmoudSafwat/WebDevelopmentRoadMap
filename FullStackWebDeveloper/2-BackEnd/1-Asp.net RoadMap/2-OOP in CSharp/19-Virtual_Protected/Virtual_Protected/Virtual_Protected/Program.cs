namespace Virtual_Protected_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Rectangle = new Rectangle { Length = 50, Width = 75 };
            Rectangle.PrintArea();
            //Rectangle.TypeName;//This is Not Allowed Because it is Access Modifiers is Protected.
            var Circle = new Circle { Radius = 90 };
            Circle.PrintArea();
        }
    }
}
