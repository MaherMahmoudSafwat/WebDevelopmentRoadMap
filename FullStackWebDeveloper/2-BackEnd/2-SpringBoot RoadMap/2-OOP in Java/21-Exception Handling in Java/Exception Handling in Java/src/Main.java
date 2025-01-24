import java.util.Scanner;
import java.util.InputMismatchException;

public class Main {
    public static void main(String[] args)
    {
       /* Yes, Exception is a class in Java, and it is part of the Java standard library.
        It is the base class for all exceptions that can be thrown and caught in Java.*/
        try
        {
            /*The try block is where you write the code that might cause an exception.
            It's used to attempt an operation that could result in an error, allowing the program to handle it gracefully
            instead of crashing.*/
            Scanner Input = new Scanner(System.in);
            System.out.println("Please enter X");
            int X = Input.nextInt();
            System.out.println("Please enter Y");
            int Y = Input.nextInt();
            System.out.println("Please enter Z");
            double Z = Input.nextInt();
            System.out.println(X/Y);
        }
        catch (ArithmeticException e)
        {
           /* First catch (ArithmeticException e) block: The catch block is used to handle specific exceptions.
            In this case, we are catching an ArithmeticException, which occurs if there is an arithmetic error
            such as division by zero.*/
            System.out.println("Error Can't divide any number by Zero");
        }
        catch (Exception e)
        {
           /* Second catch (Exception e) block: This block is a generic catch block that handles all types of
            exceptions not specifically handled by the first catch block. It is a catch-all mechanism that can deal
            with any kind of exception that might have been thrown during the execution of the try block.*/
            System.out.println("Invalid Input please try again " + e.getMessage());
        }
        System.out.println("Hello World!");
    }
}