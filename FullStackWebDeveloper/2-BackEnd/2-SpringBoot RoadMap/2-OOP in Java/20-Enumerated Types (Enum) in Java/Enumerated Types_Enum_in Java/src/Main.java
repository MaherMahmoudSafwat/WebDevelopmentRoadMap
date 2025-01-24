//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main
{
    public static void main(String[] args)
    {
        Courses C1 = Courses.Math;
        Courses C2 = Courses.DataBase;

        System.out.println(C1);//It will print Math
        // 1. compareTo() - Compares the ordinal values of two enum constants.
        System.out.println(C1.compareTo(C2));
        // If the current enum constant is before the specified one, compareTo() will return a negative value,
        // if after, it will return a positive value, and if they are the same, it returns 0.
        System.out.println(C2.compareTo(C1));
        // 2. equals() - Compares an enum constant with another object to check if they are the same.
        System.out.println(C1.equals(C2));
        // 3. ordinal() - Returns the position of the enum constant in the enum declaration, starting from 0.
        System.out.println(C1.ordinal());
        System.out.println(C2.ordinal());
        // 4. toString() - Provides a string representation of the enum constant.
        System.out.println(C1.toString());
        // By default, the toString() method returns the name of the enum constant (in uppercase).
        // However, you can override it to provide a custom string representation.

    }
}
